using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using CoreLocation;
using UserNotifications;
using CoreTelephony;
using CountlySdk;

namespace CountlyTestDemo.iOS
{

	public class MyDelegate : UIResponder, IUIApplicationDelegate
	{

	}
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
			app.WeakDelegate = new MyDelegate();

			//Basic Setting for countly server
			CountlyConfig config = new CountlyConfig();
            config.AppKey = "3295c8b1c8c7bccfb4cbeacf98bf8f9783ce6d4b";
            config.Host = "https://try.count.ly";

            //Assign additional feature to countly config object
            config.Features = new NSObject[] { Constants.CLYPushNotifications, Constants.CLYCrashReporting, Constants.CLYAutoViewTracking };


            //Manually set your deviceID to countly server
            var udid = UIKit.UIDevice.CurrentDevice.IdentifierForVendor.AsString();
            config.DeviceID = udid;
            Countly.SharedInstance().SetNewDeviceID(udid, true);
            config.AlwaysUsePOST = true;


            // You can automatically ask users for star rating
            config.StarRatingMessage = @"Would you rate the app?";
            config.StarRatingSessionCount = 10;
            config.StarRatingDisableAskingForEachAppVersion = true;



            config.CustomHeaderFieldName = @"My-Custom-Field";
            config.CustomHeaderFieldValue = @"20";


            //Add your country code and location
            config.ISOCountryCode = @"IN";
            config.City = @"Noida";
            config.Location = new CLLocationCoordinate2D(28.5986, 77.3339);



            Countly.SharedInstance().StartWithConfig(config);
			Countly.SharedInstance().AskForStarRating((obj) => Console.Write("Rating"));

			// You can record various events with different scenarios
			Countly.SharedInstance().RecordEvent("Xamarin studio", 12);
            var dict = new NSDictionary("Country", "India", "App_Version", 1.0);
            Countly.SharedInstance().RecordEvent("Xamarin_ios", dict, 12, 20, .5);

            //Tracking timed event
            Countly.SharedInstance().StartEvent("Tracking AppRating");
            Countly.SharedInstance().EndEvent("Tracking AppRating");


            // Manually set user profiles
            Countly.User.Name = "Xamarians";
            Countly.User.Username = "Xamarians";
            Countly.User.Email = "ab@doe.com";
            Countly.User.BirthYear = "1970";
            Countly.User.Organization = "United Nations";
            Countly.User.Gender = "M";
            Countly.User.Phone = "+0123456789";
            Countly.User.RecordUserDetails();

            //In addition, you can use custom user details modifiers 
            Countly.User.Set(@"key101", @"value101");
            Countly.User.IncrementBy(@"key102", 5);
            Countly.User.Multiply(@"key102", 2);
            Countly.User.Max(@"key102", 30);
            Countly.User.Min(@"key102", 20);
            Countly.User.Push(@"key103", "a");
            Countly.User.PushUnique(@"key104", @"uniqueValue");
            Countly.User.Save();


            //Auto view tracking
            Countly.SharedInstance().AddExceptionForAutoViewTracking(@"MyViewControllerTitle");
            Countly.SharedInstance().IsAutoViewTrackingEnabled = true;
            Countly.SharedInstance().ReportView("my View");


            //Push Notification
            Countly.SharedInstance().AskForNotificationPermission();
            Countly.SharedInstance().RecordLocation(new CLLocationCoordinate2D(28.5986, 77.3339));

            return base.FinishedLaunching(app, options);
        }

		public override bool OpenUrl(UIApplication app, NSUrl url, string sourceApp, NSObject annotation)
		{
			
			if (url.Scheme.Equals(@"countly"))
			{
                if (url.Host.Equals(@"productA"))
				{
				}
                else if (url.Host.Equals(@"productB"))
				{
                    // present view controller for Product B;
                    //var vc = UIApplication.SharedApplication.KeyWindow.RootViewController.PresentedViewController;
				}

				// or you can use host property directly
			}
            return true;
        }
       
	  }
    }

