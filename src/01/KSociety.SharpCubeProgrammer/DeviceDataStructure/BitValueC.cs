#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace KSociety.SharpCubeProgrammer.DeviceDataStructure
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class BitValueC
    {
        public uint Value;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 200)]
        public string Description;
    }
}