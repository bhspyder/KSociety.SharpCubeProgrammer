#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace KSociety.SharpCubeProgrammer.DeviceDataStructure
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class BitC
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string Name;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 300)]
        public string Description;

        public uint WordOffset;
        public uint BitOffset;
        public uint BitWidth;
        public byte Access;

        public uint ValuesNbr;

        //public BitValueC Values;
        public IntPtr Values;
        public BitCoefficientC Equation;
        public string Reference;
        public uint BitValue;
    }
}