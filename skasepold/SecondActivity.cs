using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Views;
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
        }


    }
}