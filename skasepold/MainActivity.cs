﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
namespace skasepold
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            var toSecond = FindViewById<Button>(Resource.Id.button1);
            var editText = FindViewById<EditText>(Resource.Id.editText1);
            var toWebView = FindViewById<Button>(Resource.Id.button2);
            toSecond.Click += delegate
              {
                  var text = editText.Text;

                  var intent = new Intent(this, typeof(SecondActivity));
                  intent.PutExtra("edittextvalue", text);
                  StartActivity(intent);
              };
            toWebView.Click();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}