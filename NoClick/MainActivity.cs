using Android.App;
using Android.Widget;
using Android.OS;
using Android.Net.Wifi;
using Android.Content;
using System;

namespace NoClick
{
    [Activity(Label = "NoClick", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button btnWifi = FindViewById<Button>(Resource.Id.btnwifi);
            btnWifi.Click += (sender, e) =>
              {
                  var intent = new Intent(this, typeof(WifiActivity));
                  StartActivity(intent);
              };
            Button btnGPS = FindViewById<Button>(Resource.Id.btnGPS);
            btnGPS.Click += (sender, e) =>
              {
                  var intent = new Intent(this, typeof(GPSActivity));
                  StartActivity(intent);
              };


        }

   
        
    }



}

