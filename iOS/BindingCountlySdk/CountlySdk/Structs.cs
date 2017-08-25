using System;
using System.Runtime.InteropServices;
using Foundation;

namespace CountlySdk
{
    static class CFunctions
    {
        // extern void CountlyInternalLog (NSString *format, ...) __attribute__((format(NSString, 1, 2)));
        [DllImport ("__Internal")]
        //[Verify (PlatformInvoke)]
        static extern void CountlyInternalLog (NSString format, IntPtr varArgs);
    }
}
