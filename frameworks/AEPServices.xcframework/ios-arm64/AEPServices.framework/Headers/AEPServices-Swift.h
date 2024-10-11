#if 0
#elif defined(__arm64__) && __arm64__
// Generated by Apple Swift version 5.9 (swiftlang-5.9.0.128.108 clang-1500.0.40.1)
#ifndef AEPSERVICES_SWIFT_H
#define AEPSERVICES_SWIFT_H
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wgcc-compat"

#if !defined(__has_include)
# define __has_include(x) 0
#endif
#if !defined(__has_attribute)
# define __has_attribute(x) 0
#endif
#if !defined(__has_feature)
# define __has_feature(x) 0
#endif
#if !defined(__has_warning)
# define __has_warning(x) 0
#endif

#if __has_include(<swift/objc-prologue.h>)
# include <swift/objc-prologue.h>
#endif

#pragma clang diagnostic ignored "-Wauto-import"
#if defined(__OBJC__)
#include <Foundation/Foundation.h>
#endif
#if defined(__cplusplus)
#include <cstdint>
#include <cstddef>
#include <cstdbool>
#include <cstring>
#include <stdlib.h>
#include <new>
#include <type_traits>
#else
#include <stdint.h>
#include <stddef.h>
#include <stdbool.h>
#include <string.h>
#endif
#if defined(__cplusplus)
#if defined(__arm64e__) && __has_include(<ptrauth.h>)
# include <ptrauth.h>
#else
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wreserved-macro-identifier"
# ifndef __ptrauth_swift_value_witness_function_pointer
#  define __ptrauth_swift_value_witness_function_pointer(x)
# endif
# ifndef __ptrauth_swift_class_method_pointer
#  define __ptrauth_swift_class_method_pointer(x)
# endif
#pragma clang diagnostic pop
#endif
#endif

#if !defined(SWIFT_TYPEDEFS)
# define SWIFT_TYPEDEFS 1
# if __has_include(<uchar.h>)
#  include <uchar.h>
# elif !defined(__cplusplus)
typedef uint_least16_t char16_t;
typedef uint_least32_t char32_t;
# endif
typedef float swift_float2  __attribute__((__ext_vector_type__(2)));
typedef float swift_float3  __attribute__((__ext_vector_type__(3)));
typedef float swift_float4  __attribute__((__ext_vector_type__(4)));
typedef double swift_double2  __attribute__((__ext_vector_type__(2)));
typedef double swift_double3  __attribute__((__ext_vector_type__(3)));
typedef double swift_double4  __attribute__((__ext_vector_type__(4)));
typedef int swift_int2  __attribute__((__ext_vector_type__(2)));
typedef int swift_int3  __attribute__((__ext_vector_type__(3)));
typedef int swift_int4  __attribute__((__ext_vector_type__(4)));
typedef unsigned int swift_uint2  __attribute__((__ext_vector_type__(2)));
typedef unsigned int swift_uint3  __attribute__((__ext_vector_type__(3)));
typedef unsigned int swift_uint4  __attribute__((__ext_vector_type__(4)));
#endif

#if !defined(SWIFT_PASTE)
# define SWIFT_PASTE_HELPER(x, y) x##y
# define SWIFT_PASTE(x, y) SWIFT_PASTE_HELPER(x, y)
#endif
#if !defined(SWIFT_METATYPE)
# define SWIFT_METATYPE(X) Class
#endif
#if !defined(SWIFT_CLASS_PROPERTY)
# if __has_feature(objc_class_property)
#  define SWIFT_CLASS_PROPERTY(...) __VA_ARGS__
# else
#  define SWIFT_CLASS_PROPERTY(...) 
# endif
#endif
#if !defined(SWIFT_RUNTIME_NAME)
# if __has_attribute(objc_runtime_name)
#  define SWIFT_RUNTIME_NAME(X) __attribute__((objc_runtime_name(X)))
# else
#  define SWIFT_RUNTIME_NAME(X) 
# endif
#endif
#if !defined(SWIFT_COMPILE_NAME)
# if __has_attribute(swift_name)
#  define SWIFT_COMPILE_NAME(X) __attribute__((swift_name(X)))
# else
#  define SWIFT_COMPILE_NAME(X) 
# endif
#endif
#if !defined(SWIFT_METHOD_FAMILY)
# if __has_attribute(objc_method_family)
#  define SWIFT_METHOD_FAMILY(X) __attribute__((objc_method_family(X)))
# else
#  define SWIFT_METHOD_FAMILY(X) 
# endif
#endif
#if !defined(SWIFT_NOESCAPE)
# if __has_attribute(noescape)
#  define SWIFT_NOESCAPE __attribute__((noescape))
# else
#  define SWIFT_NOESCAPE 
# endif
#endif
#if !defined(SWIFT_RELEASES_ARGUMENT)
# if __has_attribute(ns_consumed)
#  define SWIFT_RELEASES_ARGUMENT __attribute__((ns_consumed))
# else
#  define SWIFT_RELEASES_ARGUMENT 
# endif
#endif
#if !defined(SWIFT_WARN_UNUSED_RESULT)
# if __has_attribute(warn_unused_result)
#  define SWIFT_WARN_UNUSED_RESULT __attribute__((warn_unused_result))
# else
#  define SWIFT_WARN_UNUSED_RESULT 
# endif
#endif
#if !defined(SWIFT_NORETURN)
# if __has_attribute(noreturn)
#  define SWIFT_NORETURN __attribute__((noreturn))
# else
#  define SWIFT_NORETURN 
# endif
#endif
#if !defined(SWIFT_CLASS_EXTRA)
# define SWIFT_CLASS_EXTRA 
#endif
#if !defined(SWIFT_PROTOCOL_EXTRA)
# define SWIFT_PROTOCOL_EXTRA 
#endif
#if !defined(SWIFT_ENUM_EXTRA)
# define SWIFT_ENUM_EXTRA 
#endif
#if !defined(SWIFT_CLASS)
# if __has_attribute(objc_subclassing_restricted)
#  define SWIFT_CLASS(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) __attribute__((objc_subclassing_restricted)) SWIFT_CLASS_EXTRA
#  define SWIFT_CLASS_NAMED(SWIFT_NAME) __attribute__((objc_subclassing_restricted)) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
# else
#  define SWIFT_CLASS(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
#  define SWIFT_CLASS_NAMED(SWIFT_NAME) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
# endif
#endif
#if !defined(SWIFT_RESILIENT_CLASS)
# if __has_attribute(objc_class_stub)
#  define SWIFT_RESILIENT_CLASS(SWIFT_NAME) SWIFT_CLASS(SWIFT_NAME) __attribute__((objc_class_stub))
#  define SWIFT_RESILIENT_CLASS_NAMED(SWIFT_NAME) __attribute__((objc_class_stub)) SWIFT_CLASS_NAMED(SWIFT_NAME)
# else
#  define SWIFT_RESILIENT_CLASS(SWIFT_NAME) SWIFT_CLASS(SWIFT_NAME)
#  define SWIFT_RESILIENT_CLASS_NAMED(SWIFT_NAME) SWIFT_CLASS_NAMED(SWIFT_NAME)
# endif
#endif
#if !defined(SWIFT_PROTOCOL)
# define SWIFT_PROTOCOL(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) SWIFT_PROTOCOL_EXTRA
# define SWIFT_PROTOCOL_NAMED(SWIFT_NAME) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_PROTOCOL_EXTRA
#endif
#if !defined(SWIFT_EXTENSION)
# define SWIFT_EXTENSION(M) SWIFT_PASTE(M##_Swift_, __LINE__)
#endif
#if !defined(OBJC_DESIGNATED_INITIALIZER)
# if __has_attribute(objc_designated_initializer)
#  define OBJC_DESIGNATED_INITIALIZER __attribute__((objc_designated_initializer))
# else
#  define OBJC_DESIGNATED_INITIALIZER 
# endif
#endif
#if !defined(SWIFT_ENUM_ATTR)
# if __has_attribute(enum_extensibility)
#  define SWIFT_ENUM_ATTR(_extensibility) __attribute__((enum_extensibility(_extensibility)))
# else
#  define SWIFT_ENUM_ATTR(_extensibility) 
# endif
#endif
#if !defined(SWIFT_ENUM)
# define SWIFT_ENUM(_type, _name, _extensibility) enum _name : _type _name; enum SWIFT_ENUM_ATTR(_extensibility) SWIFT_ENUM_EXTRA _name : _type
# if __has_feature(generalized_swift_name)
#  define SWIFT_ENUM_NAMED(_type, _name, SWIFT_NAME, _extensibility) enum _name : _type _name SWIFT_COMPILE_NAME(SWIFT_NAME); enum SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_ENUM_ATTR(_extensibility) SWIFT_ENUM_EXTRA _name : _type
# else
#  define SWIFT_ENUM_NAMED(_type, _name, SWIFT_NAME, _extensibility) SWIFT_ENUM(_type, _name, _extensibility)
# endif
#endif
#if !defined(SWIFT_UNAVAILABLE)
# define SWIFT_UNAVAILABLE __attribute__((unavailable))
#endif
#if !defined(SWIFT_UNAVAILABLE_MSG)
# define SWIFT_UNAVAILABLE_MSG(msg) __attribute__((unavailable(msg)))
#endif
#if !defined(SWIFT_AVAILABILITY)
# define SWIFT_AVAILABILITY(plat, ...) __attribute__((availability(plat, __VA_ARGS__)))
#endif
#if !defined(SWIFT_WEAK_IMPORT)
# define SWIFT_WEAK_IMPORT __attribute__((weak_import))
#endif
#if !defined(SWIFT_DEPRECATED)
# define SWIFT_DEPRECATED __attribute__((deprecated))
#endif
#if !defined(SWIFT_DEPRECATED_MSG)
# define SWIFT_DEPRECATED_MSG(...) __attribute__((deprecated(__VA_ARGS__)))
#endif
#if !defined(SWIFT_DEPRECATED_OBJC)
# if __has_feature(attribute_diagnose_if_objc)
#  define SWIFT_DEPRECATED_OBJC(Msg) __attribute__((diagnose_if(1, Msg, "warning")))
# else
#  define SWIFT_DEPRECATED_OBJC(Msg) SWIFT_DEPRECATED_MSG(Msg)
# endif
#endif
#if defined(__OBJC__)
#if !defined(IBSegueAction)
# define IBSegueAction 
#endif
#endif
#if !defined(SWIFT_EXTERN)
# if defined(__cplusplus)
#  define SWIFT_EXTERN extern "C"
# else
#  define SWIFT_EXTERN extern
# endif
#endif
#if !defined(SWIFT_CALL)
# define SWIFT_CALL __attribute__((swiftcall))
#endif
#if !defined(SWIFT_INDIRECT_RESULT)
# define SWIFT_INDIRECT_RESULT __attribute__((swift_indirect_result))
#endif
#if !defined(SWIFT_CONTEXT)
# define SWIFT_CONTEXT __attribute__((swift_context))
#endif
#if !defined(SWIFT_ERROR_RESULT)
# define SWIFT_ERROR_RESULT __attribute__((swift_error_result))
#endif
#if defined(__cplusplus)
# define SWIFT_NOEXCEPT noexcept
#else
# define SWIFT_NOEXCEPT 
#endif
#if !defined(SWIFT_C_INLINE_THUNK)
# if __has_attribute(always_inline)
# if __has_attribute(nodebug)
#  define SWIFT_C_INLINE_THUNK inline __attribute__((always_inline)) __attribute__((nodebug))
# else
#  define SWIFT_C_INLINE_THUNK inline __attribute__((always_inline))
# endif
# else
#  define SWIFT_C_INLINE_THUNK inline
# endif
#endif
#if defined(_WIN32)
#if !defined(SWIFT_IMPORT_STDLIB_SYMBOL)
# define SWIFT_IMPORT_STDLIB_SYMBOL __declspec(dllimport)
#endif
#else
#if !defined(SWIFT_IMPORT_STDLIB_SYMBOL)
# define SWIFT_IMPORT_STDLIB_SYMBOL 
#endif
#endif
#if defined(__OBJC__)
#if __has_feature(objc_modules)
#if __has_warning("-Watimport-in-framework-header")
#pragma clang diagnostic ignored "-Watimport-in-framework-header"
#endif
@import Foundation;
@import ObjectiveC;
@import UIKit;
@import WebKit;
#endif

#endif
#pragma clang diagnostic ignored "-Wproperty-attribute-mismatch"
#pragma clang diagnostic ignored "-Wduplicate-method-arg"
#if __has_warning("-Wpragma-clang-attribute")
# pragma clang diagnostic ignored "-Wpragma-clang-attribute"
#endif
#pragma clang diagnostic ignored "-Wunknown-pragmas"
#pragma clang diagnostic ignored "-Wnullability"
#pragma clang diagnostic ignored "-Wdollar-in-identifier-extension"

#if __has_attribute(external_source_symbol)
# pragma push_macro("any")
# undef any
# pragma clang attribute push(__attribute__((external_source_symbol(language="Swift", defined_in="AEPServices",generated_declaration))), apply_to=any(function,enum,objc_interface,objc_category,objc_protocol))
# pragma pop_macro("any")
#endif

#if defined(__OBJC__)

/// Concrete class that provides disk caching capabilities
SWIFT_CLASS_NAMED("Cache")
@interface AEPCache : NSObject
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


/// Represents an entity type which can be stored in <code>DataQueue</code>
SWIFT_CLASS_NAMED("DataEntity")
@interface AEPDataEntity : NSObject
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


/// A thread-safe FIFO (First-In-First-Out) queue used to store <code>DataEntity</code> objects
SWIFT_PROTOCOL_NAMED("DataQueue")
@protocol AEPDataQueue
/// Adds a new <code>DataEntity</code> object to <code>DataQueue</code>
/// \param dataEntity a <code>DataEntity</code> object
///
- (BOOL)addWithDataEntity:(AEPDataEntity * _Nonnull)dataEntity;
/// Retrieves the head of this <code>DataQueue</code>, else return nil if the <code>DataQueue</code> is empty
- (AEPDataEntity * _Nullable)peek SWIFT_WARN_UNUSED_RESULT;
/// Retrieves the first <code>n</code> entries in this <code>DataQueue</code>, else return nil if the <code>DataQueue</code> is empty
- (NSArray<AEPDataEntity *> * _Nullable)peekWithN:(NSInteger)n SWIFT_WARN_UNUSED_RESULT;
/// Removes the head of this <code>DataQueue</code>
- (BOOL)remove;
/// Removes the first <code>n</code> entities in this <code>DataQueue</code>
- (BOOL)removeWithN:(NSInteger)n;
/// Removes all stored <code>DataEntity</code> object
- (BOOL)clear;
/// Returns the number of <code>DataEntity</code> objects in the DataQueue
- (NSInteger)count SWIFT_WARN_UNUSED_RESULT;
/// Closes the current <code>DataQueue</code>
- (void)close;
@end

@class NSString;

/// Defines a platform service to be used to initialize <code>DataQueue</code> objects
SWIFT_PROTOCOL_NAMED("DataQueuing")
@protocol AEPDataQueuing
/// Initialize a <code>DataQueue</code> object
/// \param label the label you assigned to the <code>DataQueue</code> at creation time.
///
///
/// returns:
/// the object of <code>DataQueue</code>, return false if failed to create an object
- (id <AEPDataQueue> _Nullable)getDataQueueWithLabel:(NSString * _Nonnull)label SWIFT_WARN_UNUSED_RESULT;
@end


/// Represents a UI element which can be dismissed
SWIFT_PROTOCOL_NAMED("Dismissible")
@protocol AEPDismissible
/// Dismisses the UI element
- (void)dismiss;
@end



/// Represents a UI element which can be shown
SWIFT_PROTOCOL_NAMED("Showable")
@protocol AEPShowable
/// Displays the UI element
- (void)show;
@end

@class NSData;
enum AEPFloatingButtonPosition : NSInteger;

/// Represents a FloatingButton UI element which is both <code>Showable</code> and <code>Dismissible</code>
SWIFT_PROTOCOL_NAMED("FloatingButtonPresentable") SWIFT_AVAILABILITY(ios_app_extension,unavailable)
@protocol AEPFloatingButtonPresentable <AEPDismissible, AEPShowable>
/// Set the Image for the floating button.
/// The size of the floating button is 60x60 (width x height), provide the image data accordingly
/// \param imageData The <code>Data</code> representation of a UIImage
///
- (void)setButtonImageWithImageData:(NSData * _Nonnull)imageData;
/// Set the initial position of floating button.
/// By default the initial position is set to <code>FloatingButtonPosition.center</code>.
/// Call this method before calling <code>floatingButton.show()</code> to set the position of the floating button when it appears.
/// \param position The <code>FloatingButtonPosition</code> defining the initial position of the floating button.
///
- (void)setInitialWithPosition:(enum AEPFloatingButtonPosition)position;
@end


/// This class is used to create a floating button
SWIFT_CLASS_NAMED("FloatingButton") SWIFT_AVAILABILITY(ios_app_extension,unavailable)
@interface AEPFloatingButton : NSObject <AEPFloatingButtonPresentable>
/// Display the floating button on the screen
- (void)show;
/// Remove the floating button from the screen
- (void)dismiss;
- (void)setButtonImageWithImageData:(NSData * _Nonnull)imageData;
- (void)setInitialWithPosition:(enum AEPFloatingButtonPosition)position;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end


/// Floating button lifecycle event listener
SWIFT_PROTOCOL_NAMED("FloatingButtonDelegate")
@protocol AEPFloatingButtonDelegate
/// Invoked when the floating button is tapped
- (void)onTapDetected;
/// Invoked when the floating button is dragged on the screen
- (void)onPanDetected;
/// Invoked when the floating button is displayed
- (void)onShowWithFloatingButton;
/// Invoked when the floating button is removed
- (void)onDismissWithFloatingButton;
@end

typedef SWIFT_ENUM_NAMED(NSInteger, AEPFloatingButtonPosition, "FloatingButtonPosition", open) {
  AEPFloatingButtonPositionCenter = 0,
  AEPFloatingButtonPositionTopRight = 1,
  AEPFloatingButtonPositionTopLeft = 2,
};



/// Represents a Fullscreen UI element which is both <code>Showable</code> and <code>Dismissible</code>
SWIFT_PROTOCOL_NAMED("FullscreenPresentable")
@protocol AEPFullscreenPresentable <AEPDismissible, AEPShowable>
@end

@class AEPMessageSettings;
@class UIGestureRecognizer;
@class UITapGestureRecognizer;

/// This class is used to create and display fullscreen messages on the current view.
SWIFT_CLASS_NAMED("FullscreenMessage") SWIFT_AVAILABILITY(ios_app_extension,unavailable)
@interface AEPFullscreenMessage : NSObject <AEPFullscreenPresentable>
/// Assignable in the constructor, <code>settings</code> control the layout and behavior of the message
@property (nonatomic, strong) AEPMessageSettings * _Nullable settings;
/// Attempt to create and show the in-app message.
/// Order of operations:
/// <ol>
///   <li>
///     check if the webview has already been created
///     a. if yes, check if the messageMonitor is allowing the message to be shown
///     i. if yes, show the message and exit the function
///     ii. if no, call onShowFailure of the listener and exit the function
///     b. if no, create the webview and assign delegates
///   </li>
///   <li>
///     check if the messageMonitor is allowing the message to be shown
///     a. if yes, show the message and exit the function
///     b. if no, call onShowFailure of the listener and exit the function
///   </li>
/// </ol>
- (void)show;
- (void)dismiss;
/// Adds an entry to <code>scriptHandlers</code> for the provided message name.
/// Handlers can be invoked from javascript in the message via
/// \param name the name of the message being passed from javascript
///
/// \param handler a method to be called when the javascript message is passed
///
- (void)handleJavascriptMessage:(NSString * _Nonnull)name withHandler:(void (^ _Nonnull)(id _Nullable))handler;
/// Generates an HTML payload pointing to the provided local assets
/// This method loops through each entry of the provided <code>map</code>, and generates a new HTML payload by replacing
/// occurrences of the key (the web URL for an image) with the value (the path to a file in local cache).
/// \param map map containing image URLs and cached file paths
///
- (void)setAssetMap:(NSDictionary<NSString *, NSString *> * _Nullable)map;
- (void)handleGesture:(UIGestureRecognizer * _Nullable)sender;
- (void)handleTap:(UITapGestureRecognizer * _Nullable)sender;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end

@class WKUserContentController;
@class WKScriptMessage;

SWIFT_AVAILABILITY(ios_app_extension,unavailable)
@interface AEPFullscreenMessage (SWIFT_EXTENSION(AEPServices)) <WKScriptMessageHandler>
- (void)userContentController:(WKUserContentController * _Nonnull)userContentController didReceiveScriptMessage:(WKScriptMessage * _Nonnull)message;
@end

@class WKWebView;
@class WKNavigationAction;
@class WKNavigation;

SWIFT_AVAILABILITY(ios_app_extension,unavailable)
@interface AEPFullscreenMessage (SWIFT_EXTENSION(AEPServices)) <WKNavigationDelegate>
- (void)webView:(WKWebView * _Nonnull)webView decidePolicyForNavigationAction:(WKNavigationAction * _Nonnull)navigationAction decisionHandler:(void (^ _Nonnull)(WKNavigationActionPolicy))decisionHandler;
/// Delegate method invoked when the webView navigation is complete.
- (void)webView:(WKWebView * _Nonnull)webView didFinishNavigation:(WKNavigation * _Null_unspecified)navigation;
@end



/// Fullscreen message lifecycle event listener
SWIFT_PROTOCOL_NAMED("FullscreenMessageDelegate") SWIFT_AVAILABILITY(ios_app_extension,unavailable)
@protocol AEPFullscreenMessageDelegate
/// Invoked when the fullscreen message is displayed
/// \param message Fullscreen message which is currently shown
///
- (void)onShowFullscreenMessage:(AEPFullscreenMessage * _Nonnull)message;
/// Invoked when the fullscreen message is dismissed
/// \param message Fullscreen message which is dismissed
///
- (void)onDismissFullscreenMessage:(AEPFullscreenMessage * _Nonnull)message;
/// Invoked when the fullscreen message is attempting to load a url
/// \param message Fullscreen message
///
/// \param url String the url being loaded by the message
///
///
/// returns:
/// True if the core wants to handle the URL (and not the fullscreen message view implementation)
- (BOOL)overrideUrlLoadFullscreenMessage:(AEPFullscreenMessage * _Nonnull)message url:(NSString * _Nullable)url SWIFT_WARN_UNUSED_RESULT;
@optional
/// Invoked when the fullscreen message finished loading its first content on the webView.
/// \param webView - the <code>WKWebView</code> instance that completed loading its initial content.
///
- (void)webViewDidFinishInitialLoading:(WKWebView * _Nonnull)webView;
@required
/// Invoked when the FullscreenMessage failed to be displayed
- (void)onShowFailure;
@end


/// This enum is used for building <code>NetworkRequest</code> objects.
typedef SWIFT_ENUM_NAMED(NSInteger, AEPHttpMethod, "HttpMethod", open) {
  AEPHttpMethodGet = 0,
  AEPHttpMethodPost = 1,
};

enum AEPLogLevel : NSInteger;

/// A Log object used to log messages for the SDK
SWIFT_CLASS_NAMED("Log")
@interface AEPLog : NSObject
/// Sets and gets the logging level of the SDK, default value is LogLevel.error
SWIFT_CLASS_PROPERTY(@property (nonatomic, class) enum AEPLogLevel logFilter;)
+ (enum AEPLogLevel)logFilter SWIFT_WARN_UNUSED_RESULT;
+ (void)setLogFilter:(enum AEPLogLevel)value;
/// Used to print more verbose information.
/// \param label the name of the label to localize message
///
/// \param message the string to be logged
///
+ (void)traceWithLabel:(NSString * _Nonnull)label message:(NSString * _Nonnull)message;
/// Information provided to the debug method should contain high-level details about the data being processed
/// \param label the name of the label to localize message
///
/// \param message the string to be logged
///
+ (void)debugWithLabel:(NSString * _Nonnull)label message:(NSString * _Nonnull)message;
/// Information provided to the warning method indicates that a request has been made to the SDK, but the SDK will be unable to perform the requested task
/// \param label the name of the label to localize message
///
/// \param message the string to be logged
///
+ (void)warningWithLabel:(NSString * _Nonnull)label message:(NSString * _Nonnull)message;
/// Information provided to the error method indicates that there has been an unrecoverable error
/// \param label the name of the label to localize message
///
/// \param message the string to be logged
///
+ (void)errorWithLabel:(NSString * _Nonnull)label message:(NSString * _Nonnull)message;
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
@end

/// An enum type representing different levels of logging used by the SDK.
/// <ul>
///   <li>
///     <em>LogLevel.trace</em> - This method should be used to deliver highly detailed information to the console.  Information provided to the <em>trace</em> method is verbose and should give insight to the developer about how the SDK is processing data.  The intended audience for <em>trace</em> logs is an Adobe SDK team member.  <em>trace</em> logs will only be printed to the console if the developer has set a LoggingMode of VERBOSE in the SDK.
///   </li>
///   <li>
///     <em>LogLevel.debug</em> - This method should be used when printing high-level information to the console about the data being processed.  The intended audience for <em>debug</em> logs is a developer integrating the SDK.  <em>debug</em> logs will be printed to the console if the developer has set a LoggingMode of VERBOSE or DEBUG in the SDK.
///   </li>
///   <li>
///     <em>LogLevel.warning</em> - This method should be used to indicate that a request has been made to the SDK, but the SDK will be unable to perform the requested task.  An example of when to use <em>warning</em> is when catching an unexpected but recoverable exception and printing its message.  The intended audience for <em>warning</em> logs is a developer integrating the SDK.  <em>warning</em> logs will be printed to the console if the developer has set a LoggingMode of VERBOSE, DEBUG, or WARNING in the SDK.
///   </li>
///   <li>
///     <em>LogLevel.error</em> - This method should be used when the SDK has determined that there is an unrecoverable error.  The intended audience for <em>error</em> logs is a developer integrating the SDK.  <em>error</em> logs are always enabled, and will be printed to the developer console regardless of the LoggingMode of the SDK.
///   </li>
/// </ul>
typedef SWIFT_ENUM_NAMED(NSInteger, AEPLogLevel, "LogLevel", open) {
  AEPLogLevelError = 0,
  AEPLogLevelWarning = 1,
  AEPLogLevelDebug = 2,
  AEPLogLevelTrace = 3,
};


/// Represents the interface of the logging service
SWIFT_PROTOCOL_NAMED("Logging")
@protocol AEPLogging
/// Logs a message
/// \param level One of the message level identifiers, e.g., DEBUG
///
/// \param label Name of a label to localize message
///
/// \param message The string message
///
- (void)logWithLevel:(enum AEPLogLevel)level label:(NSString * _Nonnull)label message:(NSString * _Nonnull)message;
@end

/// A MessageAlignment represents the anchor point on a view for a non-fullscreen message.
typedef SWIFT_ENUM_NAMED(NSInteger, AEPMessageAlignment, "MessageAlignment", open) {
  AEPMessageAlignmentCenter = 0,
  AEPMessageAlignmentLeft = 1,
  AEPMessageAlignmentRight = 2,
  AEPMessageAlignmentTop = 3,
  AEPMessageAlignmentBottom = 4,
};

/// A MessageAnimation represents the type of animation that should be used when displaying or dismissing a message.
typedef SWIFT_ENUM_NAMED(NSInteger, AEPMessageAnimation, "MessageAnimation", open) {
  AEPMessageAnimationNone = 0,
  AEPMessageAnimationLeft = 1,
  AEPMessageAnimationRight = 2,
  AEPMessageAnimationTop = 3,
  AEPMessageAnimationBottom = 4,
  AEPMessageAnimationCenter = 5,
  AEPMessageAnimationFade = 6,
};

/// A MessageGesture represents a user interaction with a UIView.
typedef SWIFT_ENUM_NAMED(NSInteger, AEPMessageGesture, "MessageGesture", open) {
  AEPMessageGestureSwipeUp = 0,
  AEPMessageGestureSwipeDown = 1,
  AEPMessageGestureSwipeLeft = 2,
  AEPMessageGestureSwipeRight = 3,
  AEPMessageGestureTapBackground = 4,
};


/// Handles message gesture support
SWIFT_CLASS("_TtC11AEPServices24MessageGestureRecognizer")
@interface MessageGestureRecognizer : UISwipeGestureRecognizer
- (nonnull instancetype)initWithTarget:(id _Nullable)target action:(SEL _Nullable)action SWIFT_UNAVAILABLE;
@end


/// The <code>MessageSettings</code> class defines how a message should be constructed, how and where it should be displayed,
/// and how the user can interact with it.
/// <code>MessageSettings</code> uses a builder pattern for construction. The <code>parent</code> can only be set during initialization.
SWIFT_CLASS_NAMED("MessageSettings")
@interface AEPMessageSettings : NSObject
/// Object that owns the message created using these settings.
@property (nonatomic, readonly) id _Nullable parent;
- (nonnull instancetype)initWithParent:(id _Nullable)parent OBJC_DESIGNATED_INITIALIZER;
- (AEPMessageSettings * _Nonnull)setBackdropColor:(NSString * _Nullable)color;
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end

@class NSURL;

/// UI Message delegate which is used to listen for current message lifecycle events
SWIFT_PROTOCOL_NAMED("MessagingDelegate")
@protocol AEPMessagingDelegate
/// Invoked when a message is displayed
/// \param message UIMessaging message that is being displayed
///
- (void)onShow:(id <AEPShowable> _Nonnull)message;
/// Invoked when a message is dismissed
/// \param message UIMessaging message that is being dismissed
///
- (void)onDismiss:(id <AEPShowable> _Nonnull)message;
/// Used to find whether messages should be shown or not
/// \param message UIMessaging message that is about to get displayed
///
///
/// returns:
/// true if the message should be shown else false
- (BOOL)shouldShowMessage:(id <AEPShowable> _Nonnull)message SWIFT_WARN_UNUSED_RESULT;
@optional
/// Called when <code>message</code> loads a URL
/// \param url the <code>URL</code> being loaded by the <code>message</code>
///
/// \param message the Message loading a <code>URL</code>
///
- (void)urlLoaded:(NSURL * _Nonnull)url byMessage:(id <AEPShowable> _Nonnull)message;
@end


/// NetworkRequest struct to be used by the NetworkService and the HttpConnectionPerformer when initiating network calls
SWIFT_CLASS_NAMED("NetworkRequest")
@interface AEPNetworkRequest : NSObject
- (nonnull instancetype)init SWIFT_UNAVAILABLE;
+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
@end




/// UIService for creating UI elements
SWIFT_PROTOCOL_NAMED("UIService") SWIFT_AVAILABILITY(ios_app_extension,unavailable)
@protocol AEPUIServiceProtocol
/// Creates a <code>FullscreenPresentable</code>
/// \param payload The payload used in the FullscreenPresentable as a string
///
/// \param listener The <code>FullscreenPresentable</code>’s <code>FullscreenMessageDelegate</code>
///
/// \param isLocalImageUsed An optional flag indicating if a local image is used instead of the default image provided
///
///
/// returns:
/// A <code>FullscreenPresentable</code> implementation
- (id <AEPFullscreenPresentable> _Nonnull)createFullscreenMessageWithPayload:(NSString * _Nonnull)payload listener:(id <AEPFullscreenMessageDelegate> _Nullable)listener isLocalImageUsed:(BOOL)isLocalImageUsed SWIFT_WARN_UNUSED_RESULT;
@optional
/// Creates a <code>FullscreenPresentable</code>
/// \param payload The payload used in the FullscreenPresentable as a string
///
/// \param listener The <code>FullscreenPresentable</code>’s <code>FullscreenMessageDelegate</code>
///
/// \param isLocalImageUsed An optional flag indicating if a local image is used instead of the default image provided
///
/// \param settings The <code>MessageSettings</code> that define construction, behavior and ownership of the newly created message
///
///
/// returns:
/// A <code>FullscreenPresentable</code> implementation
- (id <AEPFullscreenPresentable> _Nonnull)createFullscreenMessageWithPayload:(NSString * _Nonnull)payload listener:(id <AEPFullscreenMessageDelegate> _Nullable)listener isLocalImageUsed:(BOOL)isLocalImageUsed settings:(AEPMessageSettings * _Nullable)settings SWIFT_WARN_UNUSED_RESULT;
@required
/// Creates a <code>FloatingButtonPresentable</code>
/// \param listener The <code>FloatingButtonPresentable</code>’s <code>FloatingButtonDelegate</code>
///
///
/// returns:
/// A <code>FloatingButtonPresentable</code> implementation
- (id <AEPFloatingButtonPresentable> _Nonnull)createFloatingButtonWithListener:(id <AEPFloatingButtonDelegate> _Nonnull)listener SWIFT_WARN_UNUSED_RESULT;
@end

#endif
#if __has_attribute(external_source_symbol)
# pragma clang attribute pop
#endif
#if defined(__cplusplus)
#endif
#pragma clang diagnostic pop
#endif

#else
#error unsupported Swift architecture
#endif
