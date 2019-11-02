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
using Android.Webkit;
namespace skasepold
{
    [Activity(Label = "WebviewActivity")]
    public class WebviewActivity : Activity
    {
        WebView _webView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            _webView = FindViewById<WebView>(Resource.Id.webView1);
            //webView.LoadUrl("delfi.ee");
            //_webView.Settings.JavasscriptEnabled.true;
            //_webView.setWebClient(new SimpleWebViewClient());
            _webView.LoadUrl("https://delfi.ee");
       

        }

        //public override bool OnKeyDown([generatedEnum] Keycode keyCode, KeyEvent e)
        //{
        //    if(keyCode==Keycode.Back && _webView.CanGoBack())
        //    { _webView.GoBack(); }
        //    return true;
        //}
    }
}