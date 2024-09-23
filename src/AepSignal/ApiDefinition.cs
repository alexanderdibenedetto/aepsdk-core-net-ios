using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;
using AepCore;
using AepSignal;

namespace AepSignal
{
    // @interface AEPMobileSignal : NSObject
    //[Unavailable(PlatformName.TvOSAppExtension)]
    //[Unavailable(PlatformName.iOSAppExtension)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AEPMobileSignal
    {
        // @property (readonly, nonatomic, strong) id<AEPExtensionRuntime> _Nonnull runtime;
        //[Export("runtime", ArgumentSemantic.Strong)]
        //AEPExtensionRuntime Runtime { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull friendlyName;
        [Export("friendlyName")]
        string FriendlyName { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull extensionVersion;
        [Static]
        [Export("extensionVersion")]
        string ExtensionVersion { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Metadata { get; }

        // -(instancetype _Nullable)initWithRuntime:(id<AEPExtensionRuntime> _Nonnull)runtime __attribute__((objc_designated_initializer));
        [Export("initWithRuntime:")]
        [DesignatedInitializer]
        NativeHandle Constructor(AEPExtensionRuntime runtime);

        // -(void)onRegistered;
        [Export("onRegistered")]
        void OnRegistered();

        // -(void)onUnregistered;
        [Export("onUnregistered")]
        void OnUnregistered();

        // -(BOOL)readyForEvent:(AEPEvent * _Nonnull)event __attribute__((warn_unused_result("")));
        [Export("readyForEvent:")]
        bool ReadyForEvent(AEPEvent @event);
    }
}