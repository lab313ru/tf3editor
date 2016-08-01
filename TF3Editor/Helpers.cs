using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Helpers
{
    public static class Helper
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

        public static int SearchBytes(byte[] array, byte[] value, int from)
        {
            int found = 0;
            for (int i = from; i < array.Length; i++)
            {
                if (array[i] == value[found])
                {
                    if (++found == value.Length)
                    {
                        return i - found + 1;
                    }
                }
                else
                {
                    found = 0;
                }
            }
            return -1;
        }

        public static void FixAllRefs(byte[] rom, int oldAddr, int newAddr)
        {
            List<int> refs = new List<int>();

            int refFrom = -1;
            byte[] searchBytes = new byte[4];
            searchBytes.WriteLong(0, (uint)oldAddr);
            while ((refFrom = SearchBytes(
                rom, searchBytes, refFrom + 1
                )) != -1)
            {
                refs.Add(refFrom);
            }

            for (int j = 0; j < refs.Count; ++j)
            {
                rom.WriteLong(refs[j], (uint)newAddr);
            }
        }

        public static ushort ReadWord(this byte[] array, int index)
        {
            return (ushort)((array[index] << 8) | array[index + 1]);
        }

        public static byte ReadByteInc(this MemoryStream stream)
        {
            byte[] array = new byte[1];
            stream.Read(array, 0, array.Length);
            return array[0];
        }

        public static ushort ReadWord(this MemoryStream stream)
        {
            long pos = stream.Position;

            byte[] array = new byte[2];
            stream.Read(array, 0, array.Length);

            stream.Position = pos;
            return (ushort)((array[0] << 8) | array[1]);
        }

        public static ushort ReadWordInc(this MemoryStream stream)
        {
            byte[] array = new byte[2];
            stream.Read(array, 0, array.Length);
            return (ushort)((array[0] << 8) | array[1]);
        }

        public static uint ReadLong(this byte[] array, int index)
        {
            if (array == null) return 0;
            return (uint)((array[index] << 24) | (array[index + 1] << 16) | (array[index + 2] << 8) | array[index + 3]);
        }

        public static uint ReadLong(this MemoryStream stream)
        {
            long pos = stream.Position;

            byte[] array = new byte[4];
            stream.Read(array, 0, array.Length);

            stream.Position = pos;
            return (uint)((array[0] << 24) | (array[1] << 16) | (array[2] << 8) | array[3]);
        }

        public static uint ReadLongInc(this MemoryStream stream)
        {
            byte[] array = new byte[4];
            stream.Read(array, 0, array.Length);
            return (uint)((array[0] << 24) | (array[1] << 16) | (array[2] << 8) | array[3]);
        }

        public static void WriteWord(this byte[] array, int index, ushort value)
        {
            array[index++] = (byte)((value >> 8) & 0xFF);
            array[index] = (byte)(value & 0xFF);
        }

        public static void WriteWordInc(this MemoryStream stream, ushort value)
        {
            byte[] array = new byte[2];
            array[0] = (byte)((value >> 8) & 0xFF);
            array[1] = (byte)(value & 0xFF);
            stream.Write(array, 0, array.Length);
        }

        public static void WriteLong(this byte[] array, int index, uint value)
        {
            array[index++] = (byte)((value >> 24) & 0xFF);
            array[index++] = (byte)((value >> 16) & 0xFF);
            array[index++] = (byte)((value >> 8) & 0xFF);
            array[index] = (byte)(value & 0xFF);
        }

        public static void WriteLongInc(this MemoryStream stream, uint value)
        {
            byte[] array = new byte[4];
            array[0] = (byte)((value >> 24) & 0xFF);
            array[1] = (byte)((value >> 16) & 0xFF);
            array[2] = (byte)((value >> 8) & 0xFF);
            array[3] = (byte)(value & 0xFF);
            stream.Write(array, 0, array.Length);
        }

        public static void IncPos(this MemoryStream stream, int value)
        {
            stream.Seek(value, SeekOrigin.Current);
        }

        public static void SubPos(this MemoryStream stream, int value)
        {
            stream.Seek(-value, SeekOrigin.Current);
        }

        public static uint mask(byte bit_idx, byte bits_cnt = 1)
        {
            return (uint)(((1 << bits_cnt) - 1) << bit_idx);
        }

        public static Bitmap CropImage(Bitmap source, Rectangle cropArea)
        {
            return source.Clone(cropArea, source.PixelFormat);
        }

        public static byte[] BitmapToArray(Bitmap image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Bitmap BitmapFromArray(byte[] array)
        {
            using (var ms = new MemoryStream(array))
            {
                return new Bitmap(ms);
            }
        }

        public static class CompareByteArrays
        {
            [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
            private static extern int memcmp(byte[] b1, byte[] b2, long count);

            static public bool Compare(byte[] b1, byte[] b2)
            {
                return b1.Length == b2.Length && memcmp(b1, b2, b1.Length) == 0;
            }
        }

        public class ByteArraysComparer : IEqualityComparer<byte[]>
        {
            public bool Equals(byte[] x, byte[] y)
            {
                return Helper.CompareByteArrays.Compare(x, y);
            }

            public int GetHashCode(byte[] obj)
            {
                var str = Convert.ToBase64String(obj);
                return str.GetHashCode();
            }
        }

        public class ByteArraysCompareKey : IEqualityComparer<Tuple<byte[], int>>
        {
            public bool Equals(Tuple<byte[], int> x, Tuple<byte[], int> y)
            {
                return Helper.CompareByteArrays.Compare(x.Item1, y.Item1);
            }

            public int GetHashCode(Tuple<byte[], int> obj)
            {
                var str = Convert.ToBase64String(obj.Item1);
                return str.GetHashCode();
            }
        }

        public class ByteArraysCompareValue : IEqualityComparer<Tuple<byte[], int>>
        {
            public bool Equals(Tuple<byte[], int> x, Tuple<byte[], int> y)
            {
                return (x.Item2 == y.Item2);
            }

            public int GetHashCode(Tuple<byte[], int> obj)
            {
                return obj.Item2.GetHashCode();
            }
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