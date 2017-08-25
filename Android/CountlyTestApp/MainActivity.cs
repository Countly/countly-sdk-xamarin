using Android.App;
using Android.OS;
using LY.Count.Android.Sdk;
using System;

namespace CountlyTestApp
{
    [Activity(Label = "CountlyTestApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var c = Countly.SharedInstance().Init(this, "https://try.count.ly", "8651b1be8415966a91b57c5e0193d1dc2bbb7ee9");
            c.InitMessaging(this, this.Class, "PROJECT_NUMBER", Countly.CountlyMessagingMode.Test);
            var usedId = Countly.SharedInstance().DeviceID;
            var idType = Countly.SharedInstance().DeviceIDType;

            // Countly.SharedInstance().SetOptionalParametersForInitialization("2 character country code", "city", "56.42345,123.45325");
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }

        protected override void OnStart()
        {
            base.OnStart();
            Countly.SharedInstance().OnStart(this);
            Countly.SharedInstance().RecordEvent("purchase", 1, 0.99);
            try
            {
                Countly.SharedInstance().ShowStarRating(this, null);
            }
            catch (Exception ex)
            {

            }
        }

        protected override void OnStop()
        {
            base.OnStop();
            Countly.SharedInstance().OnStop();
        }
    }
}

