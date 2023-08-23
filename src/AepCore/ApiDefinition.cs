using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;
using AepServices;
using AepCore;

namespace AepCore
{
    // @protocol AEPExtension
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface AEPExtension
    {
        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Abstract]
        [Export("name")]
        string Name { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull friendlyName;
        [Abstract]
        [Export("friendlyName")]
        string FriendlyName { get; }

        // @required @property (readonly, copy, nonatomic, class) NSString * _Nonnull extensionVersion;
        [Static, Abstract]
        [Export("extensionVersion")]
        string ExtensionVersion { get; }

        // @required @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable metadata;
        [Abstract]
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Metadata { get; }

        // @required @property (readonly, nonatomic, strong) id<AEPExtensionRuntime> _Nonnull runtime;
        //[Abstract]
        //[Export("runtime", ArgumentSemantic.Strong)]
        //AEPExtensionRuntime Runtime { get; }

        // @required -(void)onRegistered;
        [Abstract]
        [Export("onRegistered")]
        void OnRegistered();

        // @required -(void)onUnregistered;
        [Abstract]
        [Export("onUnregistered")]
        void OnUnregistered();

        // @required -(BOOL)readyForEvent:(AEPEvent * _Nonnull)event __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("readyForEvent:")]
        bool ReadyForEvent(AEPEvent @event);

        // @required -(instancetype _Nullable)initWithRuntime:(id<AEPExtensionRuntime> _Nonnull)runtime;
        //[Abstract]
        //[Export("initWithRuntime:")]
        //NativeHandle Constructor(AEPExtensionRuntime runtime);
    }

    // @interface Configuration : NSObject <AEPExtension>
    [BaseType(typeof(AEPExtension), Name = "_TtC7AEPCore13Configuration")]
    [DisableDefaultCtor]
    interface Configuration : AEPExtension
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
        //[Export("initWithRuntime:")]
        //[DesignatedInitializer]
        //NativeHandle Constructor(AEPExtensionRuntime runtime);

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

    // @interface AEPEvent : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AEPEvent
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSUUID * _Nonnull id;
        [Export("id", ArgumentSemantic.Copy)]
        NSUuid Id { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull type;
        [Export("type")]
        string Type { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull source;
        [Export("source")]
        string Source { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable data;
        [NullAllowed, Export("data", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> Data { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nonnull timestamp;
        [Export("timestamp", ArgumentSemantic.Copy)]
        NSDate Timestamp { get; }

        // @property (readonly, copy, nonatomic) NSUUID * _Nullable responseID;
        [NullAllowed, Export("responseID", ArgumentSemantic.Copy)]
        NSUuid ResponseID { get; }

        // @property (readonly, copy, nonatomic) NSUUID * _Nullable parentID;
        [NullAllowed, Export("parentID", ArgumentSemantic.Copy)]
        NSUuid ParentID { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable mask;
        [NullAllowed, Export("mask", ArgumentSemantic.Copy)]
        string[] Mask { get; }

        // @property (nonatomic) uint32_t eventHash;
        [Export("eventHash")]
        uint EventHash { get; set; }

        // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name type:(NSString * _Nonnull)type source:(NSString * _Nonnull)source data:(NSDictionary<NSString *,id> * _Nullable)data;
        [Export("initWithName:type:source:data:")]
        NativeHandle Constructor(string name, string type, string source, [NullAllowed] NSDictionary<NSString, NSObject> data);

        // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name type:(NSString * _Nonnull)type source:(NSString * _Nonnull)source data:(NSDictionary<NSString *,id> * _Nullable)data mask:(NSArray<NSString *> * _Nullable)mask;
        [Export("initWithName:type:source:data:mask:")]
        NativeHandle Constructor(string name, string type, string source, [NullAllowed] NSDictionary<NSString, NSObject> data, [NullAllowed] string[] mask);

        // -(AEPEvent * _Nonnull)responseEventWithName:(NSString * _Nonnull)name type:(NSString * _Nonnull)type source:(NSString * _Nonnull)source data:(NSDictionary<NSString *,id> * _Nullable)data __attribute__((warn_unused_result("")));
        [Export("responseEventWithName:type:source:data:")]
        AEPEvent ResponseEventWithName(string name, string type, string source, [NullAllowed] NSDictionary<NSString, NSObject> data);

        // -(AEPEvent * _Nonnull)chainedEventWithName:(NSString * _Nonnull)name type:(NSString * _Nonnull)type source:(NSString * _Nonnull)source data:(NSDictionary<NSString *,id> * _Nullable)data mask:(NSArray<NSString *> * _Nullable)mask __attribute__((warn_unused_result("")));
        [Export("chainedEventWithName:type:source:data:mask:")]
        AEPEvent ChainedEventWithName(string name, string type, string source, [NullAllowed] NSDictionary<NSString, NSObject> data, [NullAllowed] string[] mask);
    }

    // @interface AEPEventHistoryRequest : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AEPEventHistoryRequest
    {
        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull mask;
        [Export("mask", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> Mask { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable fromDate;
        [NullAllowed, Export("fromDate", ArgumentSemantic.Copy)]
        NSDate FromDate { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable toDate;
        [NullAllowed, Export("toDate", ArgumentSemantic.Copy)]
        NSDate ToDate { get; }

        // -(instancetype _Nonnull)initWithMask:(NSDictionary<NSString *,id> * _Nonnull)mask from:(NSDate * _Nullable)from to:(NSDate * _Nullable)to __attribute__((objc_designated_initializer));
        [Export("initWithMask:from:to:")]
        [DesignatedInitializer]
        NativeHandle Constructor(NSDictionary<NSString, NSObject> mask, [NullAllowed] NSDate from, [NullAllowed] NSDate to);
    }

    // @interface AEPEventHistoryResult : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AEPEventHistoryResult : INativeObject
    {
        // @property (readonly, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable oldestOccurrence;
        [NullAllowed, Export("oldestOccurrence", ArgumentSemantic.Copy)]
        NSDate OldestOccurrence { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable newestOccurrence;
        [NullAllowed, Export("newestOccurrence", ArgumentSemantic.Copy)]
        NSDate NewestOccurrence { get; }

        // -(instancetype _Nonnull)initWithCount:(NSInteger)count oldest:(NSDate * _Nullable)oldest newest:(NSDate * _Nullable)newest __attribute__((objc_designated_initializer));
        [Export("initWithCount:oldest:newest:")]
        [DesignatedInitializer]
        NativeHandle Constructor(nint count, [NullAllowed] NSDate oldest, [NullAllowed] NSDate newest);
    }

    // @interface EventHubPlaceholderExtension : NSObject <AEPExtension>
    [BaseType(typeof(AEPExtension), Name = "_TtC7AEPCore28EventHubPlaceholderExtension")]
    [DisableDefaultCtor]
    interface EventHubPlaceholderExtension : AEPExtension
    {
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

        // @property (readonly, nonatomic, strong) id<AEPExtensionRuntime> _Nonnull runtime;
        //[Export("runtime", ArgumentSemantic.Strong)]
        //AEPExtensionRuntime Runtime { get; }

        // -(instancetype _Nonnull)initWithRuntime:(id<AEPExtensionRuntime> _Nonnull)runtime __attribute__((objc_designated_initializer));
        //[Export("initWithRuntime:")]
        //[DesignatedInitializer]
        //NativeHandle Constructor(AEPExtensionRuntime runtime);

        // -(void)onRegistered;
        [Export("onRegistered")]
        void OnRegistered();

        // -(void)onUnregistered;
        [Export("onUnregistered")]
        void OnUnregistered();

        // -(BOOL)readyForEvent:(AEPEvent * _Nonnull)_ __attribute__((warn_unused_result("")));
        [Export("readyForEvent:")]
        bool ReadyForEvent(AEPEvent _);
    }

    // @interface AEPEventSource : NSObject
    [BaseType(typeof(NSObject))]
    interface AEPEventSource
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull none;
        [Static]
        [Export("none")]
        string None { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull os;
        [Static]
        [Export("os")]
        string Os { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull requestContent;
        [Static]
        [Export("requestContent")]
        string RequestContent { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull requestIdentity;
        [Static]
        [Export("requestIdentity")]
        string RequestIdentity { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull requestProfile;
        [Static]
        [Export("requestProfile")]
        string RequestProfile { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull requestReset;
        [Static]
        [Export("requestReset")]
        string RequestReset { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull responseContent;
        [Static]
        [Export("responseContent")]
        string ResponseContent { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull responseIdentity;
        [Static]
        [Export("responseIdentity")]
        string ResponseIdentity { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull responseProfile;
        [Static]
        [Export("responseProfile")]
        string ResponseProfile { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull sharedState;
        [Static]
        [Export("sharedState")]
        string SharedState { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull notification;
        [Static]
        [Export("notification")]
        string Notification { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull updateConsent;
        [Static]
        [Export("updateConsent")]
        string UpdateConsent { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull updateIdentity;
        [Static]
        [Export("updateIdentity")]
        string UpdateIdentity { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull removeIdentity;
        [Static]
        [Export("removeIdentity")]
        string RemoveIdentity { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull wildcard;
        [Static]
        [Export("wildcard")]
        string Wildcard { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull resetComplete;
        [Static]
        [Export("resetComplete")]
        string ResetComplete { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull applicationLaunch;
        [Static]
        [Export("applicationLaunch")]
        string ApplicationLaunch { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull applicationClose;
        [Static]
        [Export("applicationClose")]
        string ApplicationClose { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull personalizationDecisions;
        [Static]
        [Export("personalizationDecisions")]
        string PersonalizationDecisions { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull locationHintResult;
        [Static]
        [Export("locationHintResult")]
        string LocationHintResult { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull errorResponseContent;
        [Static]
        [Export("errorResponseContent")]
        string ErrorResponseContent { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull createTracker;
        [Static]
        [Export("createTracker")]
        string CreateTracker { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull trackMedia;
        [Static]
        [Export("trackMedia")]
        string TrackMedia { get; }
    }

    // @interface AEPEventType : NSObject
    [BaseType(typeof(NSObject))]
    interface AEPEventType
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull acquisition;
        [Static]
        [Export("acquisition")]
        string Acquisition { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull analytics;
        [Static]
        [Export("analytics")]
        string Analytics { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull audienceManager;
        [Static]
        [Export("audienceManager")]
        string AudienceManager { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull campaign;
        [Static]
        [Export("campaign")]
        string Campaign { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull configuration;
        [Static]
        [Export("configuration")]
        string Configuration { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull custom;
        [Static]
        [Export("custom")]
        string Custom { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull edge;
        [Static]
        [Export("edge")]
        string Edge { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull edgeConsent;
        [Static]
        [Export("edgeConsent")]
        string EdgeConsent { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull edgeIdentity;
        [Static]
        [Export("edgeIdentity")]
        string EdgeIdentity { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull edgeMedia;
        [Static]
        [Export("edgeMedia")]
        string EdgeMedia { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull genericData;
        [Static]
        [Export("genericData")]
        string GenericData { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull genericIdentity;
        [Static]
        [Export("genericIdentity")]
        string GenericIdentity { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull genericLifecycle;
        [Static]
        [Export("genericLifecycle")]
        string GenericLifecycle { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull genericPii;
        [Static]
        [Export("genericPii")]
        string GenericPii { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull genericTrack;
        [Static]
        [Export("genericTrack")]
        string GenericTrack { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull hub;
        [Static]
        [Export("hub")]
        string Hub { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull identity;
        [Static]
        [Export("identity")]
        string Identity { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull lifecycle;
        [Static]
        [Export("lifecycle")]
        string Lifecycle { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull location;
        [Static]
        [Export("location")]
        string Location { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull media;
        [Static]
        [Export("media")]
        string Media { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull messaging;
        [Static]
        [Export("messaging")]
        string Messaging { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull offerDecisioning;
        [Static]
        [Export("offerDecisioning")]
        string OfferDecisioning { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull optimize;
        [Static]
        [Export("optimize")]
        string Optimize { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull pii;
        [Static]
        [Export("pii")]
        string Pii { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull places;
        [Static]
        [Export("places")]
        string Places { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull rulesEngine;
        [Static]
        [Export("rulesEngine")]
        string RulesEngine { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull signal;
        [Static]
        [Export("signal")]
        string Signal { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull system;
        [Static]
        [Export("system")]
        string System { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull target;
        [Static]
        [Export("target")]
        string Target { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull userProfile;
        [Static]
        [Export("userProfile")]
        string UserProfile { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull wildcard;
        [Static]
        [Export("wildcard")]
        string Wildcard { get; }
    }

    // @protocol AEPExtensionRuntime
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    //[Protocol, Model]
    //interface AEPExtensionRuntime
    //{
    //    // @required -(void)unregisterExtension;
    //    [Abstract]
    //    [Export("unregisterExtension")]
    //    void UnregisterExtension();

    //    // @required -(void)registerListenerWithType:(NSString * _Nonnull)type source:(NSString * _Nonnull)source listener:(void (^ _Nonnull)(AEPEvent * _Nonnull))listener;
    //    [Abstract]
    //    [Export("registerListenerWithType:source:listener:")]
    //    void RegisterListenerWithType(string type, string source, Action<AEPEvent> listener);

    //    // @required -(void)startEvents;
    //    [Abstract]
    //    [Export("startEvents")]
    //    void StartEvents();

    //    // @required -(void)stopEvents;
    //    [Abstract]
    //    [Export("stopEvents")]
    //    void StopEvents();

    //    // @required -(void)dispatchWithEvent:(AEPEvent * _Nonnull)event;
    //    [Abstract]
    //    [Export("dispatchWithEvent:")]
    //    void DispatchWithEvent(AEPEvent @event);

    //    // @required -(void)createSharedStateWithData:(NSDictionary<NSString *,id> * _Nonnull)data event:(AEPEvent * _Nullable)event;
    //    [Abstract]
    //    [Export("createSharedStateWithData:event:")]
    //    void CreateSharedStateWithData(NSDictionary<NSString, NSObject> data, [NullAllowed] AEPEvent @event);

    //    // @required -(void (^ _Nonnull)(NSDictionary<NSString *,id> * _Nullable))createPendingSharedStateWithEvent:(AEPEvent * _Nullable)event __attribute__((warn_unused_result("")));
    //    [Abstract]
    //    [Export("createPendingSharedStateWithEvent:")]
    //    Action<NSDictionary<NSString, NSObject>> CreatePendingSharedStateWithEvent([NullAllowed] AEPEvent @event);

    //    // @required -(AEPSharedStateResult * _Nullable)getSharedStateWithExtensionName:(NSString * _Nonnull)extensionName event:(AEPEvent * _Nullable)event barrier:(BOOL)barrier __attribute__((warn_unused_result("")));
    //    [Abstract]
    //    [Export("getSharedStateWithExtensionName:event:barrier:")]
    //    [return: NullAllowed]
    //    AEPSharedStateResult GetSharedStateWithExtensionName(string extensionName, [NullAllowed] AEPEvent @event, bool barrier);

    //    // @required -(AEPSharedStateResult * _Nullable)getSharedStateWithExtensionName:(NSString * _Nonnull)extensionName event:(AEPEvent * _Nullable)event barrier:(BOOL)barrier resolution:(enum AEPSharedStateResolution)resolution __attribute__((warn_unused_result("")));
    //    [Abstract]
    //    [Export("getSharedStateWithExtensionName:event:barrier:resolution:")]
    //    [return: NullAllowed]
    //    AEPSharedStateResult GetSharedStateWithExtensionName(string extensionName, [NullAllowed] AEPEvent @event, bool barrier, AEPSharedStateResolution resolution);

    //    // @required -(void)createXDMSharedStateWithData:(NSDictionary<NSString *,id> * _Nonnull)data event:(AEPEvent * _Nullable)event;
    //    [Abstract]
    //    [Export("createXDMSharedStateWithData:event:")]
    //    void CreateXDMSharedStateWithData(NSDictionary<NSString, NSObject> data, [NullAllowed] AEPEvent @event);

    //    // @required -(void (^ _Nonnull)(NSDictionary<NSString *,id> * _Nullable))createPendingXDMSharedStateWithEvent:(AEPEvent * _Nullable)event __attribute__((warn_unused_result("")));
    //    [Abstract]
    //    [Export("createPendingXDMSharedStateWithEvent:")]
    //    Action<NSDictionary<NSString, NSObject>> CreatePendingXDMSharedStateWithEvent([NullAllowed] AEPEvent @event);

    //    // @required -(AEPSharedStateResult * _Nullable)getXDMSharedStateWithExtensionName:(NSString * _Nonnull)extensionName event:(AEPEvent * _Nullable)event barrier:(BOOL)barrier __attribute__((warn_unused_result("")));
    //    [Abstract]
    //    [Export("getXDMSharedStateWithExtensionName:event:barrier:")]
    //    [return: NullAllowed]
    //    AEPSharedStateResult GetXDMSharedStateWithExtensionName(string extensionName, [NullAllowed] AEPEvent @event, bool barrier);

    //    // @required -(AEPSharedStateResult * _Nullable)getXDMSharedStateWithExtensionName:(NSString * _Nonnull)extensionName event:(AEPEvent * _Nullable)event barrier:(BOOL)barrier resolution:(enum AEPSharedStateResolution)resolution __attribute__((warn_unused_result("")));
    //    [Abstract]
    //    [Export("getXDMSharedStateWithExtensionName:event:barrier:resolution:")]
    //    [return: NullAllowed]
    //    AEPSharedStateResult GetXDMSharedStateWithExtensionName(string extensionName, [NullAllowed] AEPEvent @event, bool barrier, AEPSharedStateResolution resolution);

    //    // @required -(void)getHistoricalEvents:(NSArray<AEPEventHistoryRequest *> * _Nonnull)requests enforceOrder:(BOOL)enforceOrder handler:(void (^ _Nonnull)(NSArray<AEPEventHistoryResult *> * _Nonnull))handler;
    //    [Abstract]
    //    [Export("getHistoricalEvents:enforceOrder:handler:")]
    //    void GetHistoricalEvents(AEPEventHistoryRequest[] requests, bool enforceOrder, Action<NSArray<AEPEventHistoryResult>> handler);
    //}

    // @interface AEPMobileCore : NSObject
    [BaseType(typeof(NSObject))]
    interface AEPMobileCore
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull extensionVersion;
        [Static]
        [Export("extensionVersion")]
        string ExtensionVersion { get; }

        //[Wrap("WeakMessagingDelegate"), Static]
        //[NullAllowed]
        //AEPMessagingDelegate MessagingDelegate { get; set; }

        // @property (nonatomic, strong, class) id<AEPMessagingDelegate> _Nullable messagingDelegate;
        [Static]
        [NullAllowed, Export("messagingDelegate", ArgumentSemantic.Strong)]
        NSObject WeakMessagingDelegate { get; set; }

        // +(void)registerExtensions:(NSArray<Class> * _Nonnull)extensions completion:(void (^ _Nullable)(void))completion;
        [Static]
        [Export("registerExtensions:completion:")]
        void RegisterExtensions(Class[] extensions, [NullAllowed] Action completion);

        // +(void)registerExtension:(Class<AEPExtension> _Nonnull)exten completion:(void (^ _Nullable)(void))completion;
        [Static]
        [Export("registerExtension:completion:")]
        void RegisterExtension(AEPExtension exten, [NullAllowed] Action completion);

        // +(void)unregisterExtension:(Class<AEPExtension> _Nonnull)exten completion:(void (^ _Nullable)(void))completion;
        [Static]
        [Export("unregisterExtension:completion:")]
        void UnregisterExtension(AEPExtension exten, [NullAllowed] Action completion);

        // +(NSString * _Nonnull)getRegisteredExtensions __attribute__((warn_unused_result("")));
        [Static]
        [Export("getRegisteredExtensions")]
        string RegisteredExtensions { get; }

        // +(void)dispatch:(AEPEvent * _Nonnull)event;
        [Static]
        [Export("dispatch:")]
        void Dispatch(AEPEvent @event);

        // +(void)dispatch:(AEPEvent * _Nonnull)event timeout:(NSTimeInterval)timeout responseCallback:(void (^ _Nonnull)(AEPEvent * _Nullable))responseCallback;
        [Static]
        [Export("dispatch:timeout:responseCallback:")]
        void Dispatch(AEPEvent @event, double timeout, Action<AEPEvent> responseCallback);

        // +(void)registerEventListenerWithType:(NSString * _Nonnull)type source:(NSString * _Nonnull)source listener:(void (^ _Nonnull)(AEPEvent * _Nonnull))listener;
        [Static]
        [Export("registerEventListenerWithType:source:listener:")]
        void RegisterEventListenerWithType(string type, string source, Action<AEPEvent> listener);

        // +(void)setAdvertisingIdentifier:(NSString * _Nullable)identifier;
        [Static]
        [Export("setAdvertisingIdentifier:")]
        void SetAdvertisingIdentifier([NullAllowed] string identifier);

        // +(void)setPushIdentifier:(NSData * _Nullable)deviceToken;
        [Static]
        [Export("setPushIdentifier:")]
        void SetPushIdentifier([NullAllowed] NSData deviceToken);

        // +(void)setWrapperType:(enum AEPWrapperType)type;
        [Static]
        [Export("setWrapperType:")]
        void SetWrapperType(AEPWrapperType type);

        // +(void)setLogLevel:(enum AEPLogLevel)level;
        [Static]
        [Export("setLogLevel:")]
        void SetLogLevel(AEPLogLevel level);

        // +(void)setAppGroup:(NSString * _Nullable)group;
        [Static]
        [Export("setAppGroup:")]
        void SetAppGroup([NullAllowed] string group);

        // +(void)collectMessageInfo:(NSDictionary<NSString *,id> * _Nonnull)messageInfo;
        [Static]
        [Export("collectMessageInfo:")]
        void CollectMessageInfo(NSDictionary<NSString, NSObject> messageInfo);

        // +(void)collectLaunchInfo:(NSDictionary<NSString *,id> * _Nonnull)userInfo;
        [Static]
        [Export("collectLaunchInfo:")]
        void CollectLaunchInfo(NSDictionary<NSString, NSObject> userInfo);

        // +(void)collectPii:(NSDictionary<NSString *,id> * _Nonnull)data;
        [Static]
        [Export("collectPii:")]
        void CollectPii(NSDictionary<NSString, NSObject> data);
    }

    // @interface AEPCore_Swift_832 (AEPMobileCore)
    [Category]
    [BaseType(typeof(AEPMobileCore))]
    interface AEPMobileCore_AEPCore_Swift_832
    {
        // +(void)lifecycleStart:(NSDictionary<NSString *,id> * _Nullable)additionalContextData;
        [Static]
        [Export("lifecycleStart:")]
        void LifecycleStart([NullAllowed] NSDictionary<NSString, NSObject> additionalContextData);

        // +(void)lifecyclePause;
        [Static]
        [Export("lifecyclePause")]
        void LifecyclePause();
    }

    // @interface AEPCore_Swift_846 (AEPMobileCore)
    [Category]
    [BaseType(typeof(AEPMobileCore))]
    interface AEPMobileCore_AEPCore_Swift_846
    {
        // +(void)trackAction:(NSString * _Nullable)action data:(NSDictionary<NSString *,id> * _Nullable)data;
        [Static]
        [Export("trackAction:data:")]
        void TrackAction([NullAllowed] string action, [NullAllowed] NSDictionary<NSString, NSObject> data);

        // +(void)trackState:(NSString * _Nullable)state data:(NSDictionary<NSString *,id> * _Nullable)data;
        [Static]
        [Export("trackState:data:")]
        void TrackState([NullAllowed] string state, [NullAllowed] NSDictionary<NSString, NSObject> data);
    }

    // @interface AEPCore_Swift_863 (AEPMobileCore)
    [Category]
    [BaseType(typeof(AEPMobileCore))]
    interface AEPMobileCore_AEPCore_Swift_863
    {
        // +(void)configureWithAppId:(NSString * _Nonnull)appId;
        [Static]
        [Export("configureWithAppId:")]
        void ConfigureWithAppId(string appId);

        // +(void)configureWithFilePath:(NSString * _Nonnull)filePath;
        [Static]
        [Export("configureWithFilePath:")]
        void ConfigureWithFilePath(string filePath);

        // +(void)updateConfiguration:(NSDictionary<NSString *,id> * _Nonnull)configDict;
        [Static]
        [Export("updateConfiguration:")]
        void UpdateConfiguration(NSDictionary<NSString, NSObject> configDict);

        // +(void)clearUpdatedConfiguration;
        [Static]
        [Export("clearUpdatedConfiguration")]
        void ClearUpdatedConfiguration();

        // +(void)setPrivacyStatus:(enum AEPPrivacyStatus)status;
        [Static]
        [Export("setPrivacyStatus:")]
        void SetPrivacyStatus(AEPPrivacyStatus status);

        // +(void)getPrivacyStatus:(void (^ _Nonnull)(enum AEPPrivacyStatus))completion;
        [Static]
        [Export("getPrivacyStatus:")]
        void GetPrivacyStatus(Action<AEPPrivacyStatus> completion);

        // +(void)getSdkIdentities:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
        [Static]
        [Export("getSdkIdentities:")]
        void GetSdkIdentities(Action<NSString, NSError> completion);

        // +(void)resetIdentities;
        [Static]
        [Export("resetIdentities")]
        void ResetIdentities();
    }

    // @interface AEPSharedStateResult : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AEPSharedStateResult
    {
        // @property (readonly, nonatomic) enum AEPSharedStateStatus status;
        [Export("status")]
        AEPSharedStateStatus Status { get; }

        // @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nullable value;
        [NullAllowed, Export("value", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> Value { get; }
    }

}


