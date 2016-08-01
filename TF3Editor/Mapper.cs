namespace TF3Editor
{
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

        public static ushort TilePos(ushort Word)
        {
            ushort idx = TileIdx(Word);
            ushort tilesPos = (ushort)(idx * 0x20);
            if (idx >= 0x1F0 && idx <= 0x1FF) tilesPos += 0x200;
            return tilesPos;
        }

        public static ushort EncodeTileInfo(ushort idx, bool hf, bool vf, byte PalIndex)
        {
            int retn = ((PalIndex & 3) << 13) | ((vf ? 1 : 0) << 12) | ((hf ? 1 : 0) << 11) | (idx & 0x7FF);
            return (ushort)retn;
        }

        public static void ApplyMapping(ref byte[] LevelMapping, ushort[] ChangedMapping, bool PlaneA)
        {
            for (int i = 0, j = PlaneA ? 0 : 0x2000; i < 0x1000; i++, j += 2)
            {
                LevelMapping[j] = (byte)((ChangedMapping[i] & 0xFF00) >> 8);
                LevelMapping[j + 1] = (byte)(ChangedMapping[i] & 0xFF);
            }
        }

        public static ushort[] LoadMapping(byte[] LevelMapping, bool PlaneA)
        {
            ushort[] retn = new ushort[0x1000];

            for (int i = 0, j = PlaneA ? 0 : 0x2000; i < 0x1000; i++, j += 2)
                retn[i] = (ushort)(((LevelMapping[j] << 8) | LevelMapping[j + 1]) & 0x39FF);

            return retn;
        }
    }
}
