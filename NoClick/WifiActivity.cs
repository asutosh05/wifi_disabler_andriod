using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Net.Wifi;

namespace NoClick
{
    [Activity(Label = "WifiActivity")]
    public class WifiActivity : Activity
    {
        public TextView txtView;
        public Button btnWifi;
        WifiManager objWifiManager;
        ScanResultBroadcastReceiver m_ScanResultBroadcastReceiver;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Wifi);
            btnWifi = FindViewById<Button>(Resource.Id.btnwifi);
            txtView = FindViewById<TextView>(Resource.Id.txtViewWifi);

            objWifiManager = (WifiManager)GetSystemService(Context.WifiService);
            btnWifi.Text = string.Format("Wifi Status:{0}", objWifiManager.WifiState);

            m_ScanResultBroadcastReceiver = new ScanResultBroadcastReceiver();
            //m_ScanResultBroadcastReceiver.Receive += m_ScanResultBroadcastReceiver_Receiver;

            btnWifi.Click += btnWifi_Click;

        }
        void btnWifi_Click(object sender, EventArgs e)
        {
            btnWifi.Text = string.Format("Wifi Status:{0}", objWifiManager.WifiState);
            if (objWifiManager.WifiState == Android.Net.WifiState.Enabled)
            {
                //objWifiManager.StartScan();
                new AlertDialog.Builder(this)
                    .SetTitle("Alert")
                    .SetMessage("Disable Wifi ?")
                    .SetPositiveButton("Yes",delegate {
                        
                        objWifiManager.SetWifiEnabled(false);
                        btnWifi.Text = String.Format("Wifi Status: {0}", "Disabled");
                    })
                    .SetNegativeButton("No", delegate
                    {

                    })
                .Show();
            }
            else
            {
                new AlertDialog.Builder(this)
                .SetTitle("Alert")
                .SetMessage("Enable Wifi ?")
                .SetPositiveButton("Yes", delegate
                {
                    
                    objWifiManager.SetWifiEnabled(true);
                    btnWifi.Text = String.Format("Wifi Status: {0}", "Enabled");
                    //objWifiManager.StartScan();
                })
                .SetNegativeButton("No", delegate
                {

                })
                .Show();

            }
        }

        //void m_ScanResultBroadcastReceiver_Receiver(Context arg1, Intent arg2)
        //{
        //    btnWifi.Text = String.Format("Wifi Status : {0}", objWifiManager.WifiState);
        //    var wifiR = objWifiManager.ScanResults;
        //    txtView.Text = string.Empty;
        //    for (int i = 0; i < wifiR.Count; i++)
        //    {
        //        txtView.Text += wifiR[i].Ssid + System.Environment.NewLine;
        //    }

        //}
        protected override void OnResume()
        {
            base.OnResume();
            RegisterReceiver(m_ScanResultBroadcastReceiver, new IntentFilter(WifiManager.ScanResultsAvailableAction));
        }
        protected override void OnPause()
        {
            UnregisterReceiver(m_ScanResultBroadcastReceiver);
            base.OnPause();
        }

        public class ScanResultBroadcastReceiver : BroadcastReceiver
        {
            public event Action<Context, Intent> Receive;
            public override void OnReceive(Context context, Intent intent)
            {
                if (Receive != null && intent != null && intent.Action == "android.net.wifi.SCAN_RESULTS")
                {
                    this.Receive(context, intent);
                }
            }
        }
    }
}
