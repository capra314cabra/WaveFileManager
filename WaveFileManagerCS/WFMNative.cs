﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WFM
{
    namespace Native
    {
        public static class WaveFileManagerNative
        {
            const string DLL_NAME = "wavefile_manager.dll";

            [DllImport(DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
            public static extern void createFile(string path, IntPtr prop);

            [DllImport(DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
            public static extern void generateWAVEFORMATEX(IntPtr format, EDataType type);

            [DllImport(DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
            public static extern void generateMusicProperty(IntPtr mpm, IntPtr waveFormat, EDataType type, IntPtr data, UInt32 size);

            [DllImport(DLL_NAME, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
            public static extern void generateSoundMonaural16bits(IntPtr begin, UInt32 size, double herth, int samplesPerSec = 44100, int volume = 30000);
        }
    }
}
