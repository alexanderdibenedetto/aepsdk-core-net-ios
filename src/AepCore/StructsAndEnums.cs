using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;

namespace AepCore
{
    [Native]
    public enum AEPError : long
    {
        Unexpected = 0,
        CallbackTimeout = 1,
        CallbackNil = 2,
        None = 3,
        ServerError = 4,
        NetworkError = 5,
        InvalidRequest = 6,
        InvalidResponse = 7,
        ErrorExtensionNotInitialized = 11
    }

    [Native]
    public enum AEPPrivacyStatus : long
    {
        OptedIn = 0,
        OptedOut = 1,
        Unknown = 2
    }

    [Native]
    public enum AEPSharedStateResolution : long
    {
        LastSet = 0,
        Any = 1
    }

    [Native]
    public enum AEPSharedStateStatus : long
    {
        Set = 0,
        Pending = 1,
        None = 2
    }

    [Native]
    public enum AEPWrapperType : long
    {
        None = 0,
        ReactNative = 1,
        Flutter = 2,
        Cordova = 3,
        Unity = 4,
        Xamarin = 5
    }
}