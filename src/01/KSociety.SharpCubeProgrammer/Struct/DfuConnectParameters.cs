#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace KSociety.SharpCubeProgrammer.Struct
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class DfuConnectParameters
    {
        public string usb_index;
        public string rdu;

        /// <summary>
        /// Request a read unprotect: value in {0,1}.
        /// Request a TZEN regression: value in {0,1}.
        /// </summary>
        public string tzenreg;
    }
}