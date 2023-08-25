using Foundation;
using AepCore;
using AepServices;
using AEPIdentity;
using AepLifecycle;
using AepSignal;
using Security;

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
            AEPMobileCore mobileCore = new AEPMobileCore();
            AEPMobileCore.SetWrapperType(AEPWrapperType.Xamarin);
            AEPMobileCore.SetLogLevel(AEPLogLevel.Debug);
            AEPMobileCore_AEPCore_Swift_863.ConfigureWithAppId(mobileCore, "mytestAppId");

            AEPMobileCore_AEPCore_Swift_863.UpdateConfiguration(mobileCore,
                new NSDictionary<NSString, NSObject>
                {
                    ["experienceCloud.org"] = new NSString(""),
#if DEBUG || TEST
                    ["analytics.rsids"] = new NSString("hausappdev,haglobaldev"),
#else
                                ["analytics.rsids"] = new NSString("hausappprod,haglobalprod"),
#endif
                    ["analytics.server"] = new NSString("hawaiianairlines.sc.omtrdc.net"),
                    ["analytics.offlineEnabled"] = new NSNumber(false),
                    ["analytics.batchlimit"] = new NSNumber(0),
                    ["analytics.timezone"] = new NSString("HST"),
                    ["analytics.timezoneOffset"] = new NSNumber(-600),
                    ["analytics.referrerTimeout"] = new NSNumber(5),
                    ["analytics.backdatePreviousSessionInfo"] = new NSNumber(false),
                    ["lifecycle.sessionTimeout"] = new NSNumber(300)
                });

            AEPMobileCore.RegisterExtension(AEPMobileIdentity);
            //AEPLifecycle.RegisterExtension();
            //AEPSignal.RegisterExtension();

            AEPMobileCore_AEPCore_Swift_832.LifecycleStart(mobileCore, null);
        }
        catch (Exception exception)
        {
            //Log.Error(exception, "Unable to complete initialization of Adobe Analytics.");
        }
    }

}

