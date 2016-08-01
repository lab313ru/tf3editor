using System;
using IniFiles;

namespace TF3Editor
{
    public class Event
    {
        private ushort _Time;
        private byte _X;
        private byte _Y;
        private byte _DifficultyMask; //Normal(0), Hard(1), Mania(2). Game checks bit number of this byte
        private byte _ID;
        private ushort _Params;

        public ushort Time
        {
            get { return _Time; }
            set { _Time = value; }
        }

        public sbyte X
        {
            get { return (sbyte)_X; }
            set { _X = (byte)value; }
        }

        public sbyte Y
        {
            get { return (sbyte)_Y; }
            set { _Y = (byte)value; }
        }

        public bool[] DifficultyMask
        {
            get
            {
                bool[] retn = new bool[3];
                retn[0] = (_DifficultyMask & 1) != 0 ? true : false;
                retn[1] = (_DifficultyMask & 2) != 0 ? true : false;
                retn[2] = (_DifficultyMask & 4) != 0 ? true : false;
                return retn;
            }
            set { _DifficultyMask = (byte)((value[2] ? 1 << 2 : 0) | (value[1] ? 1 << 1 : 0) | (value[0] ? 1 : 0)); }
        }

        public byte ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public ushort Params
        {
            get { return _Params; }
            set { _Params = value; }
        }

        public byte[] ToByteArray()
        {
            byte[] retn = new byte[8];

            retn.WriteUInt16BE(0, _Time);
            retn[2] = _X;
            retn[3] = _Y;
            retn[4] = _DifficultyMask;
            retn[5] = _ID;
            retn.WriteUInt16BE(6, _Params);

            return retn;
        }

        public Event(ushort time, sbyte xCoord, sbyte yCoord, bool[] difficultyMask, byte id, ushort parameters)
        {
            _Time = time;
            _X = (byte)xCoord;
            _Y = (byte)yCoord;
            _ID = id;
            _Params = parameters;
            _DifficultyMask = (byte)((difficultyMask[2] ? 1 << 2 : 0) | (difficultyMask[1] ? 1 << 1 : 0) | (difficultyMask[0] ? 1 : 0));
        }

        public Event(byte[] array, int offset)
        {
            _Time = array.ReadUInt16BE(offset);
            offset += 2;
            _X = array[offset++];
            _Y = array[offset++];
            _DifficultyMask = array[offset++];
            _ID = array[offset++];
            _Params = array.ReadUInt16BE(offset);
        }

        public Event()
        {
            _Time = 0xFFFF;
            _X = 0xFF;
            _Y = 0xFF;
            _DifficultyMask = 0xFF;
            _ID = 0xFF;
            _Params = 0xFFFF;
        }

        public bool IsEmpty()
        {
            return (_Time == 0xFFFF) && ((byte)(_X) == 0xFF) && ((byte)(_Y) == 0xFF) && (_DifficultyMask == 0xFF) && (_ID == 0xFF) && (_Params == 0xFFFF);
        }

        public bool IsStartEvent()
        {
            return (_Time == 0); 
        }

        public bool IsIngameEvent()
        {
            return (_ID >= 0x00 && _ID <= 0x06);
        }

        public bool IsObjectEvent()
        {
            return (!IsIngameEvent());
        }

        public static string ObjectDescription(ushort id)
        {
            var events = new IniFile("events.ini");
            return events.Read(String.Format("{0:X2}", id), "events", String.Format("Object {0:X2}", id));
        }

        public string Description()
        {
            const string unknown = "Unknown Property or Object";
            
            if (_Time == 0)
            {
                switch (_ID)
                {
                    case 0: return "PlaneA/B Scrolling Vectors";
                    case 1: return "PlaneB Scrolling Type";
                    case 2: return "PlaneA Priority Flag";
                    case 3: return "Slowdown Factor for Animated Parts of Level";
                    default: return unknown;
                }
            }
            else
            {
                switch (_ID)
                {
                    case 0: return "PlaneA/B Scrolling Vectors";
                    case 0x1:
                        {
                            if (_Params >= 0x1 && _Params <= 0x3)
                                return "Level Speed Multiplier";
                            else
                                return "PlaneB Scrolling Type";
                        }
                    case 0x2: return "PlaneA Priority Mask";
                    case 0x3: return "Slowdown Factor for Animated Parts of Level";
                    case 0x4:
                        {
                            switch ((_Params & 0xFF00) >> 8)
                            {
                                case 0: return "Play Music Number";
                                case 1: return "Music Fadeout Timer";
                                case 2: return "Play Sound Number";
                                default: return unknown;
                            }
                        }
                    case 0x6:
                        {
                            if (_Params == 0)
                                return "Prepare Boss Data";
                            else
                                return "Call Boss";
                        }
                    case 0x7:
                    case 0x9:
                        {
                            string text = "";
                            if (_ID == 7)
                                text = " (Bonus Ship)";
                            else
                                text = " (Icon)";
                            switch (_Params)
                            {
                                case 0: return "Sever Weapon" + text;
                                case 1: return "Lancer Weapon" + text;
                                case 2: return "Wavegun Weapon" + text;
                                case 3: return "Fire/Rockets Weapon" + text;
                                case 4: return "Hunter Weapon" + text;
                                case 5: return "Shield Power-up" + text;
                                case 6: return "1 Life Power-up" + text;
                                case 7: return "Flying Claws Power-up" + text;
                                default: return unknown;
                            }
                        }
                    case 0x49:
                        {
                            string text = " (Hidden Item)";
                            switch (_Params >> 8)
                            {
                                case 0: return "Sever Weapon" + text;
                                case 1: return "Lancer Weapon" + text;
                                case 2: return "Wavegun Weapon" + text;
                                case 3: return "Fire/Rockets Weapon" + text;
                                case 4: return "Hunter Weapon" + text;
                                case 5: return "Shield Power-up" + text;
                                case 6: return "1 Life Power-up" + text;
                                case 7: return "Flying Claws Power-up" + text;
                                default: return unknown;
                            }
                        }
                    default: return ObjectDescription(_ID);
                }
            }
        }
    }
}
