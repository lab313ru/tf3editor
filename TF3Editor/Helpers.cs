using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace TF3Editor
{
    public static class ControlExtentions
    {
        /// <summary>
        /// Turn on or off control double buffering (Dirty hack!)
        /// </summary>
        /// <param name="control">Control to operate</param>
        /// <param name="setting">true to turn on double buffering</param>
        public static void MakeDoubleBuffered(this Control control, bool setting)
        {
            Type controlType = control.GetType();
            PropertyInfo pi = controlType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(control, setting, null);
        }
    }    
    
    public static class Helpers
    {
        // Note this MODIFIES THE GIVEN ARRAY then returns a reference to the modified array.
        public static byte[] Reverse(this byte[] b)
        {
            Array.Reverse(b);
            return b;
        }

        public static UInt16 ReadUInt16BE(this BinaryReader binRdr)
        {
            return BitConverter.ToUInt16(binRdr.ReadBytesRequired(sizeof(UInt16)).Reverse(), 0);
        }

        public static UInt16 ReadUInt16BE(this byte[] array, int index)
        {
            return (ushort)((array[index] << 8) | array[index + 1]);
        }

        public static UInt32 ReadUInt32BE(this BinaryReader binRdr)
        {
            return BitConverter.ToUInt32(binRdr.ReadBytesRequired(sizeof(UInt32)).Reverse(), 0);
        }

        public static UInt32 ReadUInt32BE(this byte[] array, int index)
        {
            return (uint)((array[index] << 24) | (array[index + 1] << 16) | (array[index + 2] << 8) | array[index + 3]);
        }

        public static void WriteUInt16BE(this byte[] array, int index, ushort value)
        {
            array[index++] = (byte)((value >> 8) & 0xFF);
            array[index] = (byte)(value & 0xFF);
        }

        public static void WriteUInt32BE(this byte[] array, int index, uint value)
        {
            array[index++] = (byte)((value >> 24) & 0xFF);
            array[index++] = (byte)((value >> 16) & 0xFF);
            array[index++] = (byte)((value >> 8) & 0xFF);
            array[index] = (byte)(value & 0xFF);
        }

        public static byte[] ReadBytesRequired(this BinaryReader binRdr, int byteCount)
        {
            var result = binRdr.ReadBytes(byteCount);

            if (result.Length != byteCount)
                throw new EndOfStreamException(string.Format("{0} bytes required from stream, but only {1} returned.", byteCount, result.Length));

            return result;
        }

        private static ushort SwapUInt16(ushort UInt16)
        {
            return (ushort)(((UInt16 & 0xff) << 8) | ((UInt16 >> 8) & 0xff));
        }

        private static uint SwapUInt32(uint UInt32)
        {
            return (uint)(((SwapUInt16((ushort)UInt32) & 0xffff) << 0x10) | (SwapUInt16((ushort)(UInt32 >> 0x10)) & 0xffff));
        }

        public static void WriteUInt16BE(this BinaryWriter binWrt, ushort Word)
        {
            binWrt.Write(SwapUInt16(Word));
        }

        public static void WriteUInt32BE(this BinaryWriter binWrt, uint Uint)
        {
            binWrt.Write(SwapUInt32(Uint));
        }

        public static string ReadASCIIString(this byte[] array, int offset)
        {
            int len = 0;
            byte[] str = new byte[118];
            while (array[offset + len] != 0x00)
            {
                str[len] = array[offset + len];
                if (!((str[len] >= 0x41 && str[len] <= 0x5A) || (str[len] >= 0x30 && str[len] <= 0x3A) || str[len] == 0x3F || str[len] == 0x2E || str[len] == 0x20 || str[len] == 0x0D))
                    str[len] = 0x61;
                len++;
            }
            string retn = System.Text.Encoding.ASCII.GetString(str, 0, len).Replace("a", "");
            return retn;
        }

        public static void WriteASCIIString(this byte[] array, int offset, string value)
        {
            byte[] toWrite = System.Text.Encoding.ASCII.GetBytes(value);
            Array.Copy(toWrite, 0, array, offset, toWrite.Length);
        }
    }
}
