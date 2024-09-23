using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;
using AepCore;
using AepIdentity;

namespace AepIdentity
{
    // @protocol AEPIdentifiable
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface AEPIdentifiable : INativeObject
    {
        // @required @property (readonly, copy, nonatomic) NSString * _Nullable origin;
        [Abstract]
        [NullAllowed, Export("origin")]
        string Origin { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable type;
        [Abstract]
        [NullAllowed, Export("type")]
        string Type { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nullable identifier;
        [Abstract]
        [NullAllowed, Export("identifier")]
        string Identifier { get; }

        // @required @property (readonly, nonatomic) enum AEPMobileVisitorAuthState authenticationState;
        [Abstract]
        [Export("authenticationState")]
        AEPMobileVisitorAuthState AuthenticationState { get; }
    }

    // @interface AEPMobileIdentity : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AEPMobileIdentity
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

        // -(instancetype _Nonnull)initWithRuntime:(id<AEPExtensionRuntime> _Nonnull)runtime __attribute__((objc_designated_initializer));
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

    // @interface AEPIdentity_Swift_341 (AEPMobileIdentity)
    [Category]
    [BaseType(typeof(AEPMobileIdentity))]
    interface AEPMobileIdentity_AEPIdentity_Swift_341
    {
        // +(void)appendToUrl:(NSURL * _Nullable)url completion:(void (^ _Nonnull)(NSURL * _Nullable, NSError * _Nullable))completion;
        [Static]
        [Export("appendToUrl:completion:")]
        void AppendToUrl([NullAllowed] NSUrl url, Action<NSUrl, NSError> completion);

        // +(void)getIdentifiers:(void (^ _Nonnull)(NSArray<id<AEPIdentifiable>> * _Nullable, NSError * _Nullable))completion;
        [Static]
        [Export("getIdentifiers:")]
        void GetIdentifiers(Action<NSArray<AEPIdentifiable>, NSError> completion);

        // +(void)getExperienceCloudId:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
        [Static]
        [Export("getExperienceCloudId:")]
        void GetExperienceCloudId(Action<NSString, NSError> completion);

        // +(void)syncIdentifierWithType:(NSString * _Nonnull)identifierType identifier:(NSString * _Nonnull)identifier authenticationState:(enum AEPMobileVisitorAuthState)authenticationState;
        [Static]
        [Export("syncIdentifierWithType:identifier:authenticationState:")]
        void SyncIdentifierWithType(string identifierType, string identifier, AEPMobileVisitorAuthState authenticationState);

        // +(void)syncIdentifiers:(NSDictionary<NSString *,NSString *> * _Nullable)identifiers;
        [Static]
        [Export("syncIdentifiers:")]
        void SyncIdentifiers([NullAllowed] NSDictionary<NSString, NSString> identifiers);

        // +(void)syncIdentifiers:(NSDictionary<NSString *,NSString *> * _Nullable)identifiers authenticationState:(enum AEPMobileVisitorAuthState)authenticationState;
        [Static]
        [Export("syncIdentifiers:authenticationState:")]
        void SyncIdentifiers([NullAllowed] NSDictionary<NSString, NSString> identifiers, AEPMobileVisitorAuthState authenticationState);

        // +(void)getUrlVariables:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
        [Static]
        [Export("getUrlVariables:")]
        void GetUrlVariables(Action<NSString, NSError> completion);
    }
}