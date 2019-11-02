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

namespace skasepold
{
    [Activity(Label = "WebviewAcitvity")]
    public class WebviewAcitvity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //var webView = FindViewById<WebView>(Resource.Id.web);
            WebviewAcitvity.LoadUrl("delfi.ee");
            
        }
    }
}