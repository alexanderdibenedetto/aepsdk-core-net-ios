using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;

namespace AepIdentity
{
    [Native]
    public enum AEPMobileVisitorAuthState : long
    {
        Unknown = 0,
        Authenticated = 1,
        LoggedOut = 2
    }
}