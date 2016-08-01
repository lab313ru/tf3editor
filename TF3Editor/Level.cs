using System;
using System.Collections.Generic;
using System.Drawing;
using Unformat;

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
                uint offset = baRom.ReadUInt32BE(Consts.tblLoadingScreens + bIndex * 4);
                object[] strings = baRom.ReadASCIIString((int)offset).Unformat(readInfoFormat);

                return strings;
            }

            private static void WriteInfo(string Stage, string Target, string WeakPoint)
            {
                int oldOffset = Consts.tblLoadingScreens + bIndex * 4;
                int newOffset = Consts.tblLoadingScreensNew + bIndex * 76;
                baRom.WriteUInt32BE(oldOffset, (uint)newOffset);

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

        public Bitmap BossFace(float Zoom)
        {
            Bitmap face = new Bitmap(80, 56);
            
            uint offset = baRom.ReadUInt32BE(Consts.tblBossFaces + bIndex * 4);
            byte[] faceBytesEnc = new byte[0x8C0];
            Array.Copy(baRom, Consts.tblBossFaces + offset, faceBytesEnc, 0, faceBytesEnc.Length);

            byte[] faceBytesDec = new byte[0x8C0];
            Compression.DecodeRLE(faceBytesEnc, faceBytesDec);

            return Graph.GetZoomBlockFrom2ColorArray(faceBytesDec, 10, Zoom);
        }

        public void ApplyBossFace(Bitmap newBossFace)
        {
            byte[] bossFaceDec = Graph.GetArrayFrom2ColorBlock(newBossFace);
            byte[] bossFaceEnc = new byte[0x8C0];
            int encSize = Compression.EncodeRLE(bossFaceDec, bossFaceEnc, bossFaceDec.Length);
            
            int[] sizes = new int[8];
            int[] shifts = new int[8];
            shifts[0] = 0x20;
            for (int i = 0; i < 8; i++)
            {
                uint offset = Consts.tblBossFaces + baRom.ReadUInt32BE(Consts.tblBossFaces + i * 4);
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

                baRom.WriteUInt32BE(Consts.tblBossFaces + i * 4, (uint)shifts[i]);
            }

            byte[] baRomClone = (byte[])baRom.Clone();
            for (int i = 0; i < 8; i++)
            {
                uint offset = Consts.tblBossFaces + baRom.ReadUInt32BE(Consts.tblBossFaces + i * 4);
                
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

            uint encodedSize = baRom.ReadUInt32BE(Consts.tblLevelsMain + index * 0xC + 0xA);
            uint decodedSize = baRom.ReadUInt32BE(Consts.tblLevelsMain + index * 0xC + 6); 
            uint shift = baRom.ReadUInt32BE(Consts.tblLevelsMain + index * 0xC + 2);

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

        public byte[] GetMapping()
        {
            return Decompress(1);
        }

        public byte[] GetSprites()
        {
            return Decompress(2);
        }

        public Color[] GetPalette()
        {
            Color[] retn = new Color[0x40];

            int offset = Consts.tblLevelsPalette + bIndex * 0x80;
            for (int y = 0; y < 2; y++)
                for (int x = 0; x < 16; x++, offset += 2)
                {
                    ushort W = baRom.ReadUInt16BE(offset);
                    byte r = (byte)((W & 0xE) * 0x10);
                    byte g = (byte)(((W / 0x10) & 0xE) * 0x10);
                    byte b = (byte)(((W / 0x100) & 0xE) * 0x10);
                    retn[y * 16 + x] = Color.FromArgb(r, g, b);
                }

            return retn;
        }
    }
}
