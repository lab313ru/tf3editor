namespace TF3Editor
{
    static class Consts
    {
        public const int tblLevelsMusic = 0x6D4;
        public const int tblLevelsNames = 0x6F92;
        public const int tblBossesMusic = 0x109E;
        public const int tblBossFaces = 0x1F400;
        public const int tblLoadingScreens = 0x65A4;
        public const int tblLoadingScreensNew = 0x7122;
        public const int tblLevelsMain = 0x20000;
        public const int tblLevelsPalette = 0x5FC00;

        public const int tblLevelsEvents = 0x18000;

        public static string[] eventTypes = new string[] {"00: PlaneA/B Scrolling Vectors",
            "01: Level Speed Multiplier/PlaneB Scrolling Type",
            "02: PlaneA Priority Mask",
            "03: Slowdown Factor for Animated Parts of Level",
            "04: Play Music/Music fadeout timer/Play Sound",
            "05: Unusable",
            "06: Prepare Boss Data/Call Boss",
            "07: Weapon (Bonus Ship)/Power-up (Bonus Ship)",
            "08: Red Explosion",
            "09: Weapon (Icon)/Power-up (Icon)"};
    }
}
