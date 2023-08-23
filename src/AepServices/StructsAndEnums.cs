using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;

namespace AepServices
{
    [Native]
    public enum AEPFloatingButtonPosition : long
    {
        Center = 0,
        TopRight = 1,
        TopLeft = 2
    }

    [Native]
    public enum AEPHttpMethod : long
    {
        Get = 0,
        Post = 1
    }

    [Native]
    public enum AEPLogLevel : long
    {
        Error = 0,
        Warning = 1,
        Debug = 2,
        Trace = 3
    }

    [Native]
    public enum AEPMessageAlignment : long
    {
        Center = 0,
        Left = 1,
        Right = 2,
        Top = 3,
        Bottom = 4
    }

    [Native]
    public enum AEPMessageAnimation : long
    {
        None = 0,
        Left = 1,
        Right = 2,
        Top = 3,
        Bottom = 4,
        Center = 5,
        Fade = 6
    }

    [Native]
    public enum AEPMessageGesture : long
    {
        SwipeUp = 0,
        SwipeDown = 1,
        SwipeLeft = 2,
        SwipeRight = 3,
        BackgroundTap = 4
    }
}