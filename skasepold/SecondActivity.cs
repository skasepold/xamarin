using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Views;
using Xamarin.Essentials;
using System;

namespace skasepold
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.second_layout);
            var text = Intent.GetStringExtra("edittextvalue");
            var textView = FindViewById<TextView>(Resource.Id.textView1);
            textView.Text = text;

            //xamarin essentials

            var appName = AppInfo.Name;
            var packageName = AppInfo.PackageName;
            var version=AppInfo.VersionString;
            var build = AppInfo.BuildString;

            AppInfo.ShowSettingsUI();

            var duration=TimeSpan.FromSeconds(10);
            Vibration.Vibrate(duration);



        }


    }
}