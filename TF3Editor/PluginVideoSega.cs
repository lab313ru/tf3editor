using Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace PluginVideoSega
{
    public class ScreenPoint
    {
        private byte _X = 0;
        private byte _Y = 0;
        private ushort _PlaneAddr = 0x0000;

        public ScreenPoint()
        {
        }

        public ScreenPoint(byte x, byte y)
        {
            _X = x;
            _Y = y;
        }

        public ScreenPoint(byte x, byte y, ushort planeAddr)
        {
            _X = x;
            _Y = y;
            _PlaneAddr = planeAddr;
        }

        public byte X
        {
            get { return _X; }
            set { _X = value; }
        }

        public byte Y
        {
            get { return _Y; }
            set { _Y = value; }
        }

        public ushort PlaneAddr
        {
            get { return _PlaneAddr; }
            set { _PlaneAddr = value; }
        }
    }

    public class WH
    {
        private ushort _W = 0;
        private ushort _H = 0;

        public WH()
        {
        }

        public WH(ushort w, ushort h)
        {
            _W = w;
            _H = h;
        }

        public ushort W
        {
            get { return _W; }
            set { _W = value; }
        }

        public ushort H
        {
            get { return _H; }
            set { _H = value; }
        }

        public static bool operator <(WH wh1, WH wh2)
        {
            return ((wh1.W < wh2.W) && (wh1.H == wh2.H)) || (wh1.W == wh2.W) && (wh1.H < wh2.H);
        }

        public static bool operator >(WH wh1, WH wh2)
        {
            return ((wh1.W > wh2.W) && (wh1.H == wh2.H)) || (wh1.W == wh2.W) && (wh1.H > wh2.H);
        }
    }

    public class ScreenRect
    {
        WH wh = null;
        ScreenPoint xy = null;

        public const byte Height = 0x20;
        public const byte WidthLo = 0x40;
        public const byte WidthHi = 0x80;

        public ScreenRect(WH wh, ScreenPoint xy)
        {
            this.wh = wh;
            this.xy = xy;
        }

        public ScreenRect(byte x, ushort w, byte y, ushort h, ushort planeAddr)
        {
            wh = new WH(w, h);
            xy = new ScreenPoint(x, y, planeAddr);
        }

        public ushort W
        {
            get { return wh.W; }
            set { wh.W = value; }
        }
        public ushort H
        {
            get { return wh.H; }
            set { wh.H = value; }
        }

        public byte X
        {
            get { return xy.X; }
            set { xy.X = value; }
        }

        public byte Y
        {
            get { return xy.Y; }
            set { xy.Y = value; }
        }

        public ushort PlaneAddr
        {
            get { return xy.PlaneAddr; }
            set { xy.PlaneAddr = value; }
        }

        public WH WH
        {
            get { return wh; }
            set { wh = value; }
        }

        public ScreenPoint XY
        {
            get { return xy; }
            set { xy = value; }
        }
    }

    public class LevelPoint
    {
        private ushort _X = 0;
        private ushort _Y = 0;

        public LevelPoint()
        {
        }

        public LevelPoint(ushort x, ushort y)
        {
            _X = x;
            _Y = y;
        }

        public ushort X
        {
            get { return _X; }
            set { _X = value; }
        }

        public ushort Y
        {
            get { return _Y; }
            set { _Y = value; }
        }
    }

    public static class VideoSega
    {
        public static Color[] PaletteFromByteArray(byte[] pal)
        {
            return PaletteFromByteArray(pal, 0);
        }

        public static Color[] PaletteFromByteArray(byte[] data, int offset)
        {
            Color[] retn = new Color[16];

            for (int x = 0; x < 16; x++, offset += 2)
                retn[x] = ColorFromWord(data.ReadWord(offset));

            return retn;
        }

        public static byte[] PaletteToByteArray(Color[] pal)
        {
            byte[] retn = new byte[32];

            int offset = 0;
            for (int x = 0; x < 16; x++, offset += 2)
            {
                ushort W = ColorToWord(pal[x]);

                retn[offset + 0] = (byte)((W >> 8) & 0xFF);
                retn[offset + 1] = (byte)((W >> 0) & 0xFF);
            }

            return retn;
        }

        public static ushort ColorToWord(Color color)
        {
            ushort W = 0;

            W |= (ushort)(((color.R >> 4) & 0xE) << 0);
            W |= (ushort)(((color.G >> 4) & 0xE) << 4);
            W |= (ushort)(((color.B >> 4) & 0xE) << 8);

            return W;
        }

        public static Color ColorFromWord(ushort Word)
        {
            byte r = (byte)(((Word >> 0) & 0xE) << 4);
            byte g = (byte)(((Word >> 4) & 0xE) << 4);
            byte b = (byte)(((Word >> 8) & 0xE) << 4);
            return Color.FromArgb(r, g, b);
        }

        public static Color[] PaletteApplySega(Color[] pal)
        {
            byte[] tmp = PaletteToByteArray(pal);
            return PaletteFromByteArray(tmp);
        }

        public static Color ColorApplySega(Color color)
        {
            ushort tmp = ColorToWord(color);
            return ColorFromWord(tmp);
        }

        public static void TileToData(Bitmap tile, byte[] tiles, int tilePos)
        {
            BitmapData tileData = tile.LockBits(new Rectangle(0, 0, tile.Width, tile.Height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
            byte[] tileBytes = new byte[tileData.Height * tileData.Stride];
            Marshal.Copy(tileData.Scan0, tileBytes, 0, tileBytes.Length);

            for (int h = 0; h < 8; ++h)
                for (int w = 0; w < 4; ++w)
                {
                    tiles[tilePos] = (byte)((tileBytes[h * tileData.Stride + w * 2 + 0] << 4) & 0xF0);
                    tiles[tilePos] |= (byte)((tileBytes[h * tileData.Stride + w * 2 + 1] << 0) & 0x0F);
                    tilePos++;
                }

            tile.UnlockBits(tileData);
        }

        public static bool TileFromData(byte[] bytes, BitmapData data, int x, int y, byte[] tiles, ushort word)
        {
            ushort tilePos = Mapper.TilePos(word);
            for (int h = 0; h < 8; h++)
                for (int w = 0; w < 4; w++)
                {
                    if (tilePos >= tiles.Length) return false;

                    int newW1 = x + (Mapper.HF(word) ? (7 - (w * 2 + 0)) : (w * 2 + 0));
                    int newW2 = x + (Mapper.HF(word) ? (7 - (w * 2 + 1)) : (w * 2 + 1));
                    int newH = y + (Mapper.VF(word) ? (7 - h) : h);

                    byte B = tiles[tilePos++];
                    bytes[newH * data.Stride + newW1] = (byte)((B & 0xF0) >> 4);
                    bytes[newH * data.Stride + newW2] = (byte)((B & 0x0F) >> 0);
                }

            return true;
        }

        public static Bitmap ImageMaskFromData(ushort[] mapping, ushort width, ushort height)
        {
            if (mapping == null) return null;
            if (width == 0) return null;
            if (height == 0) return null;

            Bitmap mask = new Bitmap(width * 8, height * 8, PixelFormat.Format8bppIndexed);
            ColorPalette maskPal = mask.Palette;

            for (int i = 0; i < maskPal.Entries.Length; ++i)
            {
                maskPal.Entries[i] = ColorApplySega(Color.White); // Clear palette
            }

            BitmapData data = mask.LockBits(new Rectangle(0, 0, mask.Width, mask.Height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            byte[] bytes = new byte[data.Height * data.Stride];
            Marshal.Copy(data.Scan0, bytes, 0, bytes.Length);

            byte pal = 0;
            for (ushort y = 0; y < height; ++y)
                for (ushort x = 0; x < width; ++x)
                {
                    ushort word = mapping[y * width + x];
                    bool prior = Mapper.P(word);
                    pal = Mapper.PalIdx(word);

                    for (int h = 0; h < 8; h++)
                        for (int w = 0; w < 8; w++)
                        {
                            bytes[(y * 8 + h) * data.Stride + (x * 8 + w)] = (byte)(prior ? 1 : 0);
                        }
                }

            maskPal.Entries[1] = Color.FromArgb((pal << 4), 0, 0); // First color for non prior
            mask.Palette = maskPal;

            Marshal.Copy(bytes, 0, data.Scan0, bytes.Length);
            mask.UnlockBits(data);

            return mask;
        }

        public static Bitmap ImageFromData(byte[] tiles, ushort[] mapping, Color[] palette, ushort widthInTiles, ushort heightInTiles)
        {
            if (tiles == null) return null;
            if (mapping == null) return null;
            if (palette == null) return null;
            if (widthInTiles == 0) return null;
            if (heightInTiles == 0) return null;

            Bitmap image = new Bitmap(widthInTiles * 8, heightInTiles * 8, PixelFormat.Format8bppIndexed);

            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            byte[] imageBytes = new byte[imageData.Height * imageData.Stride];
            Marshal.Copy(imageData.Scan0, imageBytes, 0, imageBytes.Length);

            for (ushort y = 0; y < heightInTiles; ++y)
                for (ushort x = 0; x < widthInTiles; ++x)
                    if (!TileFromData(imageBytes, imageData, x * 8, y * 8, tiles, mapping[y * widthInTiles + x]))
                    {
                        image.UnlockBits(imageData);
                        return null;
                    }

            Marshal.Copy(imageBytes, 0, imageData.Scan0, imageBytes.Length);
            image.UnlockBits(imageData);

            PaletteToImage(image, palette);

            return image;
        }

        public static void ImageToData(Bitmap image, Bitmap mask, out byte[] tiles, out ushort[] mapping, out Color[] palette, out ushort width, out ushort height)
        {
            width = (ushort)image.Width;
            height = (ushort)image.Height;

            List<Tuple<byte[], int>> tilesAllHF = new List<Tuple<byte[], int>>();
            List<byte[][]> tilesAll = new List<byte[][]>();

            for (ushort y = 0; y < height; y += 8)
                for (ushort x = 0; x < width; x += 8)
                {
                    int idx = (y / 8) * (width / 8) + (x / 8);

                    Rectangle rect = new Rectangle(x, y, 8, 8);
                    Bitmap tile = Helper.CropImage(image, rect);

                    byte[] hash00 = Helper.BitmapToArray(tile); // !HF, !VF
                    tile.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    byte[] hash10 = Helper.BitmapToArray(tile); //  HF, !VF
                    tile.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    byte[] hash11 = Helper.BitmapToArray(tile); //  HF,  VF
                    tile.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    byte[] hash01 = Helper.BitmapToArray(tile); // !HF,  VF

                    tilesAll.Add(new byte[][] { hash00, hash10, hash11, hash01 });

                    tilesAllHF.Add(new Tuple<byte[], int>(hash00, idx));
                    tilesAllHF.Add(new Tuple<byte[], int>(hash10, idx));
                    tilesAllHF.Add(new Tuple<byte[], int>(hash11, idx));
                    tilesAllHF.Add(new Tuple<byte[], int>(hash01, idx));
                }

            tilesAllHF = tilesAllHF.Distinct(new Helper.ByteArraysCompareKey()).ToList(); //remove tile duplicates
            tilesAllHF = tilesAllHF.Distinct(new Helper.ByteArraysCompareValue()).ToList(); //remove tile duplicates

            BitmapData maskData = null;
            byte[] maskBytes = null;

            if (mask != null)
            {
                maskData = mask.LockBits(new Rectangle(0, 0, mask.Width, mask.Height), ImageLockMode.ReadOnly, PixelFormat.Format8bppIndexed);
                maskBytes = new byte[maskData.Height * maskData.Stride];
                Marshal.Copy(maskData.Scan0, maskBytes, 0, maskBytes.Length);
            }

            MemoryStream stream = new MemoryStream();
            for (int i = 0; i < tilesAll.Count; ++i)
            {
                int x = (i % (width / 8));
                int y = (i / (width / 8));

                int idx = 0;
                for (int l = 0; l < tilesAll[i].Length; ++l)
                    if ((idx = tilesAllHF.FindIndex(a => Helper.CompareByteArrays.Compare(a.Item1, tilesAll[i][l]))) >= 0)
                    {
                        ushort word = 0;
                        bool HF = false, VF = false; // !HF, !VF
                        switch (l)
                        {
                            case 1: // HF, !VF
                                HF = true; VF = false;
                                break;

                            case 2: // HF, VF
                                HF = true; VF = true;
                                break;

                            case 3: // !HF, VF
                                HF = false; VF = true;
                                break;
                        }

                        bool prior = false;

                        if (mask != null)
                        {
                            for (int h = 0; h < 8; h++)
                                for (int w = 0; w < 8; w++)
                                    if (maskBytes[(y * 8 + h) * maskData.Stride + (x * 8 + w)] == 1)
                                    {
                                        prior = true;
                                        break;
                                    }

                            word = Mapper.EncodeTileInfo((ushort)idx, HF, VF, (byte)(mask.Palette.Entries[1].R >> 4), prior);
                        }
                        else
                        {
                            word = Mapper.EncodeTileInfo((ushort)idx, HF, VF, 0, prior);
                        }

                        stream.WriteWordInc(word);
                        break;
                    }
            }

            if (mask != null)
            {
                mask.UnlockBits(maskData);
            }

            width /= 8;
            height /= 8;

            mapping = Mapper.ByteMapToWordMap(stream.ToArray());
            palette = PaletteFromImage(image);

            int tilesCount = tilesAllHF.Count;
            tiles = new byte[0x20 * tilesCount];

            for (int i = 0; i < tilesCount; ++i)
            {
                Bitmap tile = Helper.BitmapFromArray(tilesAllHF[i].Item1);
                TileToData(tile, tiles, i * 0x20);
                tile.Dispose();
            }
        }

        public static Bitmap TilesetFromData(byte[] tiles, Color[] palette, out int tilesCount, ushort tilesInRow = 16)
        {
            tilesCount = (tiles != null ? (tiles.Length / 0x20) : 0);
            tilesInRow = (ushort)((tilesCount < tilesInRow) ? tilesCount : tilesInRow);

            if (tilesCount != 0)
            {
                ushort[] mapping = new ushort[tilesCount];

                for (int x = 0; x < tilesCount; x++)
                {
                    mapping[x] = Mapper.EncodeTileInfo((ushort)x, false, false, 0, false);
                }

                return ImageFromData(tiles, mapping, palette, tilesInRow, (ushort)(tilesCount / tilesInRow));
            }

            return null;
        }

        public static Color[] PaletteFromImage(Bitmap image)
        {
            Color[] colors = new Color[16];

            for (int i = 0; i < colors.Length; ++i)
            {
                colors[i] = ColorApplySega(image.Palette.Entries[i]);
            }

            return colors;
        }

        public static void PaletteToImage(Bitmap image, Color[] palette)
        {
            ColorPalette imagePal = image.Palette;

            for (int i = 0; i < imagePal.Entries.Length; ++i)
            {
                imagePal.Entries[i] = ColorApplySega(Color.Black); // Clear palette
            }
            for (int i = 0; i < palette.Length; ++i)
            {
                imagePal.Entries[i] = Color.FromArgb(
                    palette[i].R | ((i & 0x0C) >> 2),
                    palette[i].G | ((i & 0x02) >> 1),
                    palette[i].B | ((i & 0x01) >> 0)
                    ); // Fill image palette
            }
            image.Palette = imagePal;
        }

        public static ushort GetVramWriteAddr(uint value)
        {
            return (ushort)(((value & Helper.mask(0, 2)) << 14) | ((value & Helper.mask(16, 14)) >> 16));
        }

        public static uint SetVramWriteAddr(ushort value)
        {
            return (uint)(((value >> 14) & Helper.mask(0, 2)) | ((value << 16) & Helper.mask(16, 14)) | (1 << 30));
        }

        public static ScreenPoint VramAddrToScreenPoint(ushort vramAddr, byte screenSize)
        {
            ushort planeAddr = (ushort)(vramAddr & 0xE000);
            vramAddr &= 0x1FFF;
            vramAddr >>= 1;
            byte x = (byte)(vramAddr % screenSize);
            byte y = (byte)(vramAddr / screenSize);
            return new ScreenPoint(x, y, planeAddr);
        }

        public static ushort VramAddrFromScreenPoint(ScreenPoint xy, byte screenSize)
        {
            ushort vramAddr = (ushort)(xy.Y * screenSize + xy.X);
            vramAddr <<= 1;
            vramAddr &= 0x1FFF;
            vramAddr |= (ushort)(xy.PlaneAddr & 0xE000);
            return vramAddr;
        }
    }

    public static class Mapper
    {
        public static ushort TileIdx(ushort Word)
        {
            return (ushort)(Word & 0x7FF);
        }

        public static byte PalIdx(ushort Word)
        {
            return (byte)((Word & 0x6000) >> 13);
        }

        public static bool HF(ushort Word)
        {
            return ((Word & 0x800) >> 11) == 1;
        }

        public static bool VF(ushort Word)
        {
            return ((Word & 0x1000) >> 12) == 1;
        }

        public static bool P(ushort Word)
        {
            return ((Word & 0x8000) >> 15) == 1;
        }

        public static ushort ApplyTileIdx(ushort Word, ushort tileIdx)
        {
            return (ushort)((Word & ~0x07FF) | tileIdx);
        }

        public static ushort ApplyPalIdx(ushort Word, byte palIdx)
        {
            return (ushort)((Word & ~0x6000) | (palIdx << 13));
        }

        public static ushort ApplyHF(ushort Word, int hf)
        {
            return (ushort)((Word & ~0x0800) | (hf << 11));
        }

        public static ushort ApplyVF(ushort Word, int vf)
        {
            return (ushort)((Word & ~0x1000) | (vf << 12));
        }

        public static ushort ApplyP(ushort Word, int p)
        {
            return (ushort)((Word & ~0x8000) | (p << 15));
        }

        public static ushort TilePos(ushort Word)
        {
            ushort idx = TileIdx(Word);
            ushort tilesPos = (ushort)(idx * 0x20);
            return tilesPos;
        }

        public static ushort EncodeTileInfo(ushort idx, bool hf, bool vf, byte palIndex, bool p)
        {
            int retn = ((p ? 1 : 0) << 15) | ((palIndex & 3) << 13) | ((vf ? 1 : 0) << 12) | ((hf ? 1 : 0) << 11) | (idx & 0x7FF);
            return (ushort)retn;
        }

        public static byte[] WordMapToByteMap(ushort[] wordMap, ushort StartMask = 0)
        {
            int len = wordMap.Length;

            byte[] retn = new byte[len * 2];
            for (int i = 0, j = 0; i < len; i++, j += 2)
            {
                retn[j] = (byte)(((wordMap[i] & 0xFF00) >> 8) - StartMask);
                retn[j + 1] = (byte)((wordMap[i] & 0xFF) - StartMask);
            }

            return retn;
        }

        public static ushort[] ByteMapToWordMap(byte[] byteMap, ushort StartMask = 0)
        {
            int len = byteMap.Length / 2;
            ushort[] retn = new ushort[len];
            for (int i = 0, j = 0; i < len; i++, j += 2)
                retn[i] = (ushort)((((byteMap[j] << 8) | byteMap[j + 1]) & 0xFFFF) + StartMask);
            return retn;
        }
    }
}