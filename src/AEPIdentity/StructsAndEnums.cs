using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;

namespace AEPIdentity
{
    [Native]
    public enum AEPMobileVisitorAuthState : long
    {
        Unknown = 0,
        Authenticated = 1,
        LoggedOut = 2
    }
}