using System;
using Helpers;
using System.Collections.Generic;
using System.Drawing;
using Unformat;
using PluginVideoSega;
using TMX;

namespace TF3Editor
{
    class Level
    {
        private static byte bIndex = 0;
        private static byte[] baRom = null;
        private static List<Event> elEvents = new List<Event>();

        public Level(ref byte[] Rom, byte Index)
        {
            bIndex = Index;
            baRom = Rom;
        }

        //public static string[] Names = new string[8] { "Hydra", "Gorgon", "Seiren", "Haides", "Ellis", "Cerberus", "Orn Base", "Orn Core" };
        public string[] Names
        {
            get
            {
                string[] retn = new string[8];

                for (int i = 0; i < 8; i++)
                {
                    uint offset = (uint)(Consts.tblLevelsNames + i * 10);
                    retn[i] = baRom.ReadASCIIString((int)offset);
                }
                return retn;
            }
        }

        public byte Index
        {
            get { return bIndex; }
            set { bIndex = value; ReadEventsTable(); }
        }

        public string Name()
        {
            return Names[bIndex];
        }
        
        public byte MusicIndex
        {
            get { return baRom[Consts.tblLevelsMusic + bIndex]; }
            set { baRom[Consts.tblLevelsMusic + bIndex] = value; }
        }

        public byte BossMusicIndex
        {
            get { return baRom[Consts.tblBossesMusic + bIndex]; }
            set { baRom[Consts.tblBossesMusic + bIndex] = value; }
        }

        public Event GetEvent(int Index)
        {
            return elEvents[Index];
        }

        public void SetEvent(int Index, Event Value)
        {
            int offset = Consts.tblLevelsEvents + bIndex * 0xC00;
            Array.Copy(Value.ToByteArray(), 0, baRom, offset + Index * 8, 8);

            if (Index == elEvents.Count)
                elEvents.Add(Value);
            else
                elEvents[Index] = Value;
        }

        public void DelEvent(int Index)
        {
            int offset = Consts.tblLevelsEvents + bIndex * 0xC00;

            for (int i = 0; i < 0x180; i++)
            {
                Array.Copy((new Event()).ToByteArray(), 0, baRom, offset + i * 8, 8);
            }

            elEvents.RemoveAt(Index);
            for (int i = 0; i < elEvents.Count; i++)
            {
                Array.Copy(elEvents[i].ToByteArray(), 0, baRom, offset + i * 8, 8);
            }
        }

        public int EventsCount()
        {
            return elEvents.Count;
        }

        public void ReadEventsTable()
        {
            int offset = Consts.tblLevelsEvents + bIndex * 0xC00;

            elEvents.Clear();

            for (int i = 0; i < 0x180; i++)
            {
                Event _event = new Event(baRom, offset + i * 8);
                if (!_event.IsEmpty()) elEvents.Add(_event);
            }
        }

        public LoadingScreenStruct LoadingScreen;

        public struct LoadingScreenStruct
        {
            const string readInfoFormat = "STAGE\r  {0}\r\rTARGET\r  {1}\r\rWEAK POINT\r  {2}";
            const string writeInfoFormat = "STAGE\xD\x2  {0}\xD\xD\x4TARGET\xD\x2  {1}\xD\xD\x4WEAK POINT\xD\x2  {2}\x0";

            private static object[] ParseInfo()
            {
                uint offset = baRom.ReadLong(Consts.tblLoadingScreens + bIndex * 4);
                object[] strings = baRom.ReadASCIIString((int)offset).Unformat(readInfoFormat);

                return strings;
            }

            private static void WriteInfo(string Stage, string Target, string WeakPoint)
            {
                int oldOffset = Consts.tblLoadingScreens + bIndex * 4;
                int newOffset = Consts.tblLoadingScreensNew + bIndex * 76;
                baRom.WriteLong(oldOffset, (uint)newOffset);

                baRom.WriteASCIIString(newOffset, String.Format(writeInfoFormat, Stage == "" ? "\xD" : Stage, Target == "" ? "\xD" : Target, WeakPoint == "" ? "\xD" : WeakPoint));
            }

            private static void WriteStage(string stage)
            {
                WriteInfo(stage, (string)ParseInfo()[1], (string)ParseInfo()[2]);
            }

            private static void WriteTarget(string target)
            {
                WriteInfo((string)ParseInfo()[0], target, (string)ParseInfo()[2]);
            }

            private static void WriteWeakPoint(string weakPoint)
            {
                WriteInfo((string)ParseInfo()[0], (string)ParseInfo()[1], weakPoint);
            }
            
            public string Stage
            {
                get { return (string)ParseInfo()[0]; }
                set { WriteStage(value); }
            }

            public string Target
            {
                get { return (string)ParseInfo()[1]; }
                set { WriteTarget(value); }
            }

            public string WeakPoint
            {
                get { return (string)ParseInfo()[2]; }
                set { WriteWeakPoint(value); }
            }
        }

        public Bitmap BossFace()
        {
            Bitmap face = new Bitmap(80, 56);
            
            uint offset = baRom.ReadLong(Consts.tblBossFaces + bIndex * 4);
            byte[] faceBytesEnc = new byte[0x8C0];
            Array.Copy(baRom, Consts.tblBossFaces + offset, faceBytesEnc, 0, faceBytesEnc.Length);

            byte[] faceBytesDec = new byte[0x8C0];
            Compression.DecodeRLE(faceBytesEnc, faceBytesDec);

            Color[] palette = new Color[] { Color.Black,
                Color.Black, Color.Black, Color.Black, Color.Black, Color.Black,
                Color.Black, Color.Black, Color.Black, Color.Black, Color.Black,
                Color.Black, Color.Black, Color.Black, Color.Black,
                Color.White };
            ushort[] mapping = new ushort[10 * 7];

            for (ushort i = 0; i < 10 * 7; ++i)
                mapping[i] = Mapper.EncodeTileInfo(i, false, false, 0, false);

            return VideoSega.ImageFromData(faceBytesDec, mapping, palette, 10, 7);
        }

        public void ApplyBossFace(Bitmap newBossFace)
        {
            byte[] bossFaceDec;
            ushort[] mapping;
            Color[] palette;
            ushort width, height;

            VideoSega.ImageToData(newBossFace, null, out bossFaceDec, out mapping, out palette, out width, out height);
            byte[] bossFaceEnc = new byte[0x8C0];
            int encSize = Compression.EncodeRLE(bossFaceDec, bossFaceEnc, bossFaceDec.Length);
            
            int[] sizes = new int[8];
            int[] shifts = new int[8];
            shifts[0] = 0x20;
            for (int i = 0; i < 8; i++)
            {
                uint offset = Consts.tblBossFaces + baRom.ReadLong(Consts.tblBossFaces + i * 4);
                byte[] enc = new byte[0x8C0];
                byte[] dec = new byte[0x8C0];
                Array.Copy(baRom, offset, enc, 0, enc.Length);
                Compression.DecodeRLE(enc, dec);

                if (i != bIndex)
                    sizes[i] = Compression.EncodeRLE(dec, enc, dec.Length);
                else
                    sizes[i] = encSize;

                if (i != 0) shifts[i] = shifts[i - 1] + sizes[i - 1];
                if (shifts[i] % 2 != 0) shifts[i]++;

                baRom.WriteLong(Consts.tblBossFaces + i * 4, (uint)shifts[i]);
            }

            byte[] baRomClone = (byte[])baRom.Clone();
            for (int i = 0; i < 8; i++)
            {
                uint offset = Consts.tblBossFaces + baRom.ReadLong(Consts.tblBossFaces + i * 4);
                
                if (i == bIndex)
                    Array.Copy(bossFaceEnc, 0, baRom, offset, encSize);
                else
                    Array.Copy(baRomClone, offset, baRom, offset, sizes[i]);
            }
        }

        private byte[] Decompress(int Index)
        {
            int index = 0;

            switch (Index)
            {
                case 0: index = bIndex + 0x08; break;
                case 1: index = bIndex + 0x10; break;
                case 2: index = bIndex + 0x00; break;
            }

            uint encodedSize = baRom.ReadLong(Consts.tblLevelsMain + index * 0xC + 0xA);
            uint decodedSize = baRom.ReadLong(Consts.tblLevelsMain + index * 0xC + 6); 
            uint shift = baRom.ReadLong(Consts.tblLevelsMain + index * 0xC + 2);

            byte[] input = new byte[encodedSize];
            Array.Copy(baRom, Consts.tblLevelsMain + shift, input, 0, encodedSize);

            byte[] retn = new byte[decodedSize];
            Compression.DecodeLZH(input, retn, (int)encodedSize, decodedSize);
            return retn;
        }

        public byte[] GetTiles()
        {
            return Decompress(0);//0x300 tiles, but 0x200..0x2FF - only for animation and can't be selected.
        }

        public byte[] GetMappingA()
        {
            byte[] mapping = Decompress(1);
            byte[] retn = new byte[0x2000];

            Array.Copy(mapping, 0, retn, 0, 0x2000);
            return retn;
        }

        public byte[] GetMappingB()
        {
            byte[] mapping = Decompress(1);
            byte[] retn = new byte[0x2000];

            Array.Copy(mapping, 0x2000, retn, 0, 0x2000);
            return retn;
        }

        public byte[] GetSprites()
        {
            return Decompress(2);
        }

        public Color[][] GetPalette()
        {
            Color[][] retn = new Color[2][];

            for (int i = 0; i < 2; ++i)
            {
                retn[i] = VideoSega.PaletteFromByteArray(baRom, Consts.tblLevelsPalette + bIndex * 0x80 + i * 16);
            }

            return retn;
        }

        public static int ConvertXYtoTileIndex(ushort width, ushort x, ushort y)
        {
            return (x / 2) * 4 + (width / 2) * (y / 2) * 4 + (y % 2) * 2 + (x % 2);
        }

        public void TmxExport(string path)
        {
            string tilesetA = string.Format("{0}-TilesetA.png", Name());
            string tilesetB = string.Format("{0}-TilesetB.png", Name());

            TmxGenerator tmx = new TmxGenerator();

            const ushort widthAB = 0x200;
            const ushort heightA = 16;
            const ushort heightB = 8;

            tmx.WriteMap(widthAB, heightA);

            byte[] tilesAB = GetTiles();
            Color[][] caPaletteAB = GetPalette();

            ushort[] mappingA = Mapper.ByteMapToWordMap(GetMappingA());
            ushort[] mappingB = Mapper.ByteMapToWordMap(GetMappingB());

            int countPlaneA = TmxGenerator.TilesetExport(tilesetA, tilesAB, caPaletteAB[0]);

            if (countPlaneA > 0)
                tmx.WriteTileset("tilesA", tilesetA, caPaletteAB[0][0], 1, 0);

            int countPlaneB = TmxGenerator.TilesetExport(tilesetB, tilesAB, caPaletteAB[1]);

            if (countPlaneB > 0)
                tmx.WriteTileset("tilesB", tilesetB, caPaletteAB[1][0], 1 + countPlaneA, 0);

            if (countPlaneB > 0)
                tmx.LayerFromMapping("planeB", mappingB, 1 + countPlaneA, widthAB, heightB, ConvertXYtoTileIndex);
            if (countPlaneA > 0)
                tmx.LayerFromMapping("planeA", mappingA, 1, widthAB, heightA, ConvertXYtoTileIndex);

            tmx.Save(path);
        }
    }
}
