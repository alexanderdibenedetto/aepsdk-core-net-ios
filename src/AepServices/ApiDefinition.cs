using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Security;
using UIKit;
using WebKit;
using AepServices;

namespace AepServices
{
    // @interface AEPCache : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AEPCache
    {
    }

    // @interface AEPDataEntity : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AEPDataEntity
    {
    }

    partial interface IAEPDataQueue : AEPDataQueue { }

    // @protocol AEPDataQueue
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol, Model]
    interface AEPDataQueue
    {
        // @required -(BOOL)addWithDataEntity:(AEPDataEntity * _Nonnull)dataEntity;
        [Abstract]
        [Export("addWithDataEntity:")]
        bool AddWithDataEntity(AEPDataEntity dataEntity);

        // @required -(AEPDataEntity * _Nullable)peek __attribute__((warn_unused_result("")));
        [Abstract]
        [NullAllowed, Export("peek")]
        AEPDataEntity Peek();

        // @required -(NSArray<AEPDataEntity *> * _Nullable)peekWithN:(NSInteger)n __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("peekWithN:")]
        [return: NullAllowed]
        AEPDataEntity[] PeekWithN(nint n);

        // @required -(BOOL)remove;
        [Abstract]
        [Export("remove")]
        bool Remove();

        // @required -(BOOL)removeWithN:(NSInteger)n;
        [Abstract]
        [Export("removeWithN:")]
        bool RemoveWithN(nint n);

        // @required -(BOOL)clear;
        [Abstract]
        [Export("clear")]
        bool Clear();

        // @required -(NSInteger)count __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("count")]
        nint Count { get; }

        // @required -(void)close;
        [Abstract]
        [Export("close")]
        void Close();
    }

    // @protocol AEPDataQueuing
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
    interface AEPDataQueuing
    {
        // @required -(id<AEPDataQueue> _Nullable)getDataQueueWithLabel:(NSString * _Nonnull)label __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("getDataQueueWithLabel:")]
        [return: NullAllowed]
        IAEPDataQueue GetDataQueueWithLabel(string label);
    }

    // @protocol AEPDismissible
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
    interface AEPDismissible
    {
        // @required -(void)dismiss;
        [Abstract]
        [Export("dismiss")]
        void Dismiss();
    }

    partial interface IAEPDismissible : AEPDismissible { }

    // @protocol AEPShowable
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
    interface AEPShowable
    {
        // @required -(void)show;
        [Abstract]
        [Export("show")]
        void Show();
    }

    partial interface IAEPShowable : AEPShowable { }

    // @protocol AEPFloatingButtonPresentable <AEPDismissible, AEPShowable>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    //[Unavailable(PlatformName.iOSAppExtension)]
    [Protocol, Model]
    interface AEPFloatingButtonPresentable
    {
        // @required -(void)setButtonImageWithImageData:(NSData * _Nonnull)imageData;
        [Abstract]
        [Export("setButtonImageWithImageData:")]
        void SetButtonImageWithImageData(NSData imageData);

        // @required -(void)setInitialWithPosition:(enum AEPFloatingButtonPosition)position;
        [Abstract]
        [Export("setInitialWithPosition:")]
        void SetInitialWithPosition(AEPFloatingButtonPosition position);
    }

    partial interface IAEPFloatingButtonPresentable : AEPFloatingButtonPresentable { }

    // @interface AEPFloatingButton : NSObject <AEPFloatingButtonPresentable>
    //[Unavailable(PlatformName.iOSAppExtension)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AEPFloatingButton : IAEPFloatingButtonPresentable
    {
        // -(void)show;
        [Export("show")]
        void Show();

        // -(void)dismiss;
        [Export("dismiss")]
        void Dismiss();

        // -(void)setButtonImageWithImageData:(NSData * _Nonnull)imageData;
        [Export("setButtonImageWithImageData:")]
        void SetButtonImageWithImageData(NSData imageData);

        // -(void)setInitialWithPosition:(enum AEPFloatingButtonPosition)position;
        [Export("setInitialWithPosition:")]
        void SetInitialWithPosition(AEPFloatingButtonPosition position);
    }

    // @protocol AEPFloatingButtonDelegate
    [Protocol, Model]
    interface AEPFloatingButtonDelegate
    {
        // @required -(void)onTapDetected;
        [Abstract]
        [Export("onTapDetected")]
        void OnTapDetected();

        // @required -(void)onPanDetected;
        [Abstract]
        [Export("onPanDetected")]
        void OnPanDetected();

        // @required -(void)onShowWithFloatingButton;
        [Abstract]
        [Export("onShowWithFloatingButton")]
        void OnShowWithFloatingButton();

        // @required -(void)onDismissWithFloatingButton;
        [Abstract]
        [Export("onDismissWithFloatingButton")]
        void OnDismissWithFloatingButton();
    }

    // @protocol AEPFullscreenPresentable <AEPDismissible, AEPShowable>
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
    interface AEPFullscreenPresentable
    {
    }

    // @interface AEPFullscreenMessage : NSObject <AEPFullscreenPresentable>
    //[Unavailable(PlatformName.iOSAppExtension)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AEPFullscreenMessage
    {
        // @property (nonatomic, strong) AEPMessageSettings * _Nullable settings;
        [NullAllowed, Export("settings", ArgumentSemantic.Strong)]
        AEPMessageSettings Settings { get; set; }

        // -(void)show;
        [Export("show")]
        void Show();

        // -(void)dismiss;
        [Export("dismiss")]
        void Dismiss();

        // -(void)handleJavascriptMessage:(NSString * _Nonnull)name withHandler:(void (^ _Nonnull)(id _Nullable))handler;
        [Export("handleJavascriptMessage:withHandler:")]
        void HandleJavascriptMessage(string name, Action<NSObject> handler);

        // -(void)setAssetMap:(NSDictionary<NSString *,NSString *> * _Nullable)map;
        [Export("setAssetMap:")]
        void SetAssetMap([NullAllowed] NSDictionary<NSString, NSString> map);

        // -(void)handleGesture:(UIGestureRecognizer * _Nullable)sender;
        [Export("handleGesture:")]
        void HandleGesture([NullAllowed] UIGestureRecognizer sender);

        // -(void)handleTap:(UITapGestureRecognizer * _Nullable)sender;
        [Export("handleTap:")]
        void HandleTap([NullAllowed] UITapGestureRecognizer sender);
    }

    // @interface AEPServices_Swift_485 (AEPFullscreenMessage) <WKScriptMessageHandler>
    //[Unavailable(PlatformName.iOSAppExtension)]
    //[Category]
    //[BaseType(typeof(AEPFullscreenMessage))]
    //interface AEPFullscreenMessage_AEPServices_Swift_485 : IWKScriptMessageHandler
    //{
    //    // -(void)userContentController:(WKUserContentController * _Nonnull)userContentController didReceiveScriptMessage:(WKScriptMessage * _Nonnull)message;
    //    [Export("userContentController:didReceiveScriptMessage:")]
    //    void UserContentController(WKUserContentController userContentController, WKScriptMessage message);
    //}

    // @interface AEPServices_Swift_494 (AEPFullscreenMessage) <WKNavigationDelegate>
    //[Unavailable(PlatformName.iOSAppExtension)]
    //[Category]
    //[BaseType(typeof(AEPFullscreenMessage))]
    //interface AEPFullscreenMessage_AEPServices_Swift_494 : IWKNavigationDelegate
    //{
    //    // -(void)webView:(WKWebView * _Nonnull)webView decidePolicyForNavigationAction:(WKNavigationAction * _Nonnull)navigationAction decisionHandler:(void (^ _Nonnull)(WKNavigationActionPolicy))decisionHandler __attribute__((swift_async("not_swift_private", 3)));
    //    [Export("webView:decidePolicyForNavigationAction:decisionHandler:")]
    //    void WebView(WKWebView webView, WKNavigationAction navigationAction, Action<WKNavigationActionPolicy> decisionHandler);

    //    // -(void)webView:(WKWebView * _Nonnull)webView didFinishNavigation:(WKNavigation * _Null_unspecified)navigation;
    //    [Export("webView:didFinishNavigation:")]
    //    void WebView(WKWebView webView, WKNavigation navigation);
    //}

    // @protocol AEPFullscreenMessageDelegate
    //[Unavailable(PlatformName.iOSAppExtension)]
    [Protocol, Model]
    interface AEPFullscreenMessageDelegate
    {
        // @required -(void)onShowFullscreenMessage:(AEPFullscreenMessage * _Nonnull)message;
        [Abstract]
        [Export("onShowFullscreenMessage:")]
        void OnShowFullscreenMessage(AEPFullscreenMessage message);

        // @required -(void)onDismissFullscreenMessage:(AEPFullscreenMessage * _Nonnull)message;
        [Abstract]
        [Export("onDismissFullscreenMessage:")]
        void OnDismissFullscreenMessage(AEPFullscreenMessage message);

        // @required -(BOOL)overrideUrlLoadFullscreenMessage:(AEPFullscreenMessage * _Nonnull)message url:(NSString * _Nullable)url __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("overrideUrlLoadFullscreenMessage:url:")]
        bool OverrideUrlLoadFullscreenMessage(AEPFullscreenMessage message, [NullAllowed] string url);

        // @optional -(void)webViewDidFinishInitialLoading:(WKWebView * _Nonnull)webView;
        [Export("webViewDidFinishInitialLoading:")]
        void WebViewDidFinishInitialLoading(WKWebView webView);

        // @required -(void)onShowFailure;
        [Abstract]
        [Export("onShowFailure")]
        void OnShowFailure();
    }

    // @interface AEPLog : NSObject
    [BaseType(typeof(NSObject))]
    interface AEPLog
    {
        // @property (nonatomic, class) enum AEPLogLevel logFilter;
        [Static]
        [Export("logFilter", ArgumentSemantic.Assign)]
        AEPLogLevel LogFilter { get; set; }

        // +(void)traceWithLabel:(NSString * _Nonnull)label message:(NSString * _Nonnull)message;
        [Static]
        [Export("traceWithLabel:message:")]
        void TraceWithLabel(string label, string message);

        // +(void)debugWithLabel:(NSString * _Nonnull)label message:(NSString * _Nonnull)message;
        [Static]
        [Export("debugWithLabel:message:")]
        void DebugWithLabel(string label, string message);

        // +(void)warningWithLabel:(NSString * _Nonnull)label message:(NSString * _Nonnull)message;
        [Static]
        [Export("warningWithLabel:message:")]
        void WarningWithLabel(string label, string message);

        // +(void)errorWithLabel:(NSString * _Nonnull)label message:(NSString * _Nonnull)message;
        [Static]
        [Export("errorWithLabel:message:")]
        void ErrorWithLabel(string label, string message);
    }

    // @protocol AEPLogging
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
    interface AEPLogging
    {
        // @required -(void)logWithLevel:(enum AEPLogLevel)level label:(NSString * _Nonnull)label message:(NSString * _Nonnull)message;
        [Abstract]
        [Export("logWithLevel:label:message:")]
        void Label(AEPLogLevel level, string label, string message);
    }

    //// @interface MessageGestureRecognizer : UISwipeGestureRecognizer
    //[BaseType(typeof(UISwipeGestureRecognizer), Name = "_TtC11AEPServices24MessageGestureRecognizer")]
    //interface MessageGestureRecognizer
    //{
    //}

    // @interface AEPMessageSettings : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AEPMessageSettings
    {
        // @property (readonly, nonatomic) id _Nullable parent;
        [NullAllowed, Export("parent")]
        NSObject Parent { get; }

        // -(instancetype _Nonnull)initWithParent:(id _Nullable)parent __attribute__((objc_designated_initializer));
        [Export("initWithParent:")]
        [DesignatedInitializer]
        NativeHandle Constructor([NullAllowed] NSObject parent);

        // -(AEPMessageSettings * _Nonnull)setBackdropColor:(NSString * _Nullable)color;
        [Export("setBackdropColor:")]
        AEPMessageSettings SetBackdropColor([NullAllowed] string color);
    }

    // @protocol AEPMessagingDelegate
    //[Protocol, Model]
    //interface AEPMessagingDelegate
    //{
    //    // @required -(void)onShow:(id<AEPShowable> _Nonnull)message;
    //    [Abstract]
    //    [Export("onShow:")]
    //    void OnShow(AEPShowable message);

    //    // @required -(void)onDismiss:(id<AEPShowable> _Nonnull)message;
    //    [Abstract]
    //    [Export("onDismiss:")]
    //    void OnDismiss(AEPShowable message);

    //    // @required -(BOOL)shouldShowMessage:(id<AEPShowable> _Nonnull)message __attribute__((warn_unused_result("")));
    //    [Abstract]
    //    [Export("shouldShowMessage:")]
    //    bool ShouldShowMessage(AEPShowable message);

    //    // @optional -(void)urlLoaded:(NSURL * _Nonnull)url byMessage:(id<AEPShowable> _Nonnull)message;
    //    [Export("urlLoaded:byMessage:")]
    //    void UrlLoaded(NSUrl url, AEPShowable message);
    //}

    // @interface AEPNetworkRequest : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AEPNetworkRequest
    {
    }

    // @protocol AEPUIServiceProtocol
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    //[Unavailable(PlatformName.iOSAppExtension)]
    //[Protocol]
    //interface AEPUIServiceProtocol
    //{
    //    // @required -(id<AEPFullscreenPresentable> _Nonnull)createFullscreenMessageWithPayload:(NSString * _Nonnull)payload listener:(id<AEPFullscreenMessageDelegate> _Nullable)listener isLocalImageUsed:(BOOL)isLocalImageUsed __attribute__((warn_unused_result("")));
    //    [Abstract]
    //    [Export("createFullscreenMessageWithPayload:listener:isLocalImageUsed:")]
    //    AEPFullscreenPresentable CreateFullscreenMessageWithPayload(string payload, [NullAllowed] AEPFullscreenMessageDelegate listener, bool isLocalImageUsed);

    //    // @optional -(id<AEPFullscreenPresentable> _Nonnull)createFullscreenMessageWithPayload:(NSString * _Nonnull)payload listener:(id<AEPFullscreenMessageDelegate> _Nullable)listener isLocalImageUsed:(BOOL)isLocalImageUsed settings:(AEPMessageSettings * _Nullable)settings __attribute__((warn_unused_result("")));
    //    [Export("createFullscreenMessageWithPayload:listener:isLocalImageUsed:settings:")]
    //    AEPFullscreenPresentable CreateFullscreenMessageWithPayload(string payload, [NullAllowed] AEPFullscreenMessageDelegate listener, bool isLocalImageUsed, [NullAllowed] AEPMessageSettings settings);

    //    // @required -(id<AEPFloatingButtonPresentable> _Nonnull)createFloatingButtonWithListener:(id<AEPFloatingButtonDelegate> _Nonnull)listener __attribute__((warn_unused_result("")));
    //    [Abstract]
    //    [Export("createFloatingButtonWithListener:")]
    //    AEPFloatingButtonPresentable CreateFloatingButtonWithListener(AEPFloatingButtonDelegate listener);
    //}
}