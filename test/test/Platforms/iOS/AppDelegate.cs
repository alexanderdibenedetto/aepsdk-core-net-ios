using Foundation;
using AepCore;
using AepServices;
using AepIdentity;
using AepLifecycle;
using AepSignal;
using Security;
using System.Diagnostics;
using System;
using ObjCRuntime;

namespace test;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp()
    {
        return MauiProgram.CreateMauiApp();
    }

    public override bool FinishedLaunching(UIKit.UIApplication application, NSDictionary launchOptions)
    {
        InitializeAdobeMobile();
        return base.FinishedLaunching(application, launchOptions);
    }

    private void InitializeAdobeMobile()
   {
        try
        {
            // set the wrapper type
            AEPMobileCore.SetWrapperType(AEPWrapperType.Xamarin);
            AEPMobileCore.SetLogLevel(AEPLogLevel.Debug);

            // set your configuration
            var keys = new[]
            {
                new NSString("analytics.timezone"),
                new NSString("analytics.timezoneOffset"),
                new NSString("analytics.referrerTimeout"),
                new NSString("analytics.backdatePreviousSessionInfo"),
                new NSString("lifecycle.sessionTimeout")
            };
            var objects = new NSObject[]
            {
                new NSString("UTC"),
                new NSNumber(0),
                new NSNumber(5),
                new NSNumber(false),
                new NSNumber(300)
            };
            NSDictionary<NSString, NSObject> dict = new(keys, objects);
            AEPMobileCore_AEPCore_Swift_863.UpdateConfiguration((null as AEPMobileCore), dict);

            // register any extensions being used with adobe mobile.
            AEPMobileCore.RegisterExtensions(
                new Class[]
                {
                    new Class(typeof(AEPMobileIdentity)),
                    new Class(typeof(AEPMobileLifecycle)),
                    new Class(typeof(AEPMobileSignal))
                },
                OnRegistrationComplete);
        }
        catch (Exception exception)
        {
            Debug.WriteLine($"Unable to complete initialization of Adobe.{Environment.NewLine}{exception.Message}{exception.StackTrace}");
        }
    }

    private void OnRegistrationComplete()
    {
        Debug.WriteLine($"Extension registrations complete.");
        // configure with your app id.
        AEPMobileCore_AEPCore_Swift_863.ConfigureWithAppId((null as AEPMobileCore), "com.companyname.test");
        // start the analytics collection lifecycle for the initial app open.
        AEPMobileCore_AEPCore_Swift_832.LifecycleStart((null as AEPMobileCore), null);
        Debug.WriteLine($"Adobe initialized successfully.");
    }

    public void PlatformTrackState(string state, NSDictionary<NSString, NSObject> data)
    {
        AEPMobileCore_AEPCore_Swift_846.TrackState((null as AEPMobileCore), state, data);
    }

    public void PlatformTrackAction(string action, NSDictionary<NSString, NSObject> data)
    {
        AEPMobileCore_AEPCore_Swift_846.TrackAction((null as AEPMobileCore), action, data);
    }

    public async Task<string> GenerateVisitorUrl(string url)
    {
        if (!string.IsNullOrWhiteSpace(url))
        {
            TaskCompletionSource<NSUrl> taskCompletionSource = new TaskCompletionSource<NSUrl>();
            Action<NSUrl, NSError> callback = OnGenerateVisitorUrlTaskCompletion(taskCompletionSource);
            await Task.Factory.StartNew(() =>
            {
                try
                {
                    AEPMobileIdentity_AEPIdentity_Swift_294.AppendToUrl((null as AEPMobileIdentity), NSUrl.FromString(url), callback);
                }
                catch (Exception exception)
                {
                    taskCompletionSource.TrySetException(exception);
                }
            }, TaskCreationOptions.AttachedToParent);

            return (await Task.FromResult(taskCompletionSource.Task.Result))?.AbsoluteString ?? url;
        }
        return url;
    }

    public async Task<string> GetUrlVariables()
    {
        TaskCompletionSource<NSString> taskCompletionSource = new();
        Action<NSString, NSError> callback = OnGetUrlVariablesTaskCompletion(taskCompletionSource);

        await Task.Factory.StartNew(() =>
        {
            try
            {
                AEPMobileIdentity_AEPIdentity_Swift_294.GetUrlVariables((null as AEPMobileIdentity), callback);
            }
            catch (Exception exception)
            {
                taskCompletionSource.TrySetException(exception);
            }
        }, TaskCreationOptions.AttachedToParent);
        return await Task.FromResult(taskCompletionSource.Task.Result);
    }

    private static Action<NSString, NSError> OnGetUrlVariablesTaskCompletion(TaskCompletionSource<NSString> taskCompletionSource)
    {
        return (NSString @string, NSError error) =>
        {
            if (error == null)
            {
                taskCompletionSource.SetResult(@string);
            }
            else
            {
                taskCompletionSource.SetException(new NSErrorException(error));
            }
        };
    }

    private static Action<NSUrl, NSError> OnGenerateVisitorUrlTaskCompletion(TaskCompletionSource<NSUrl> taskCompletionSource)
    {
        return (NSUrl @url, NSError error) =>
        {
            if (error == null)
            {
                taskCompletionSource.SetResult(@url);
            }
            else
            {
                taskCompletionSource.SetException(new NSErrorException(error));
            }
        };
    }
}