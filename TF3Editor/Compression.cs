using System;
using System.IO;
using System.Runtime.InteropServices;
namespace TF3Editor
{
    public static class Compression
    {
        [DllImport(@"TF3Compression.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int EncodeLZH(byte[] input, byte[] output, int inlen);
        [DllImport(@"TF3Compression.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DecodeLZH(byte[] input, byte[] output, int inlen, uint decsize);

        [DllImport(@"TF3Compression.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int EncodeRLE(byte[] input, byte[] output, int inlen);
        [DllImport(@"TF3Compression.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int DecodeRLE(byte[] input, byte[] output);
    }
}
