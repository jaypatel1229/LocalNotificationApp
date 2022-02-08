using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace LocNotEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button button;
        private static readonly int ButtonClickNotification = 9999;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            button = FindViewById<Button>(Resource.Id.btnSend);
            button.Click += (s, e) => {
                Bundle valuesSend = new Bundle();
                valuesSend.PutString("sendContent","This is the Content Send From Activity 1");
            };

            Intent newIntent = new Intent(this,typeof(Second_Activity));
           
        }
       
    }
}