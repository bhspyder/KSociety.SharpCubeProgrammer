#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace KSociety.SharpCubeProgrammer.DeviceDataStructure
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class CategoryC
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string Name;

        public uint BitsNbr;

        public IntPtr Bits;
    }
}