using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Android.Support.V7.App;
using Fragment = Android.App.Fragment;
using Xamarin.Forms.Platform.Android;
using Android.Support.V4.App;

namespace AndroidSfListView
{
    [Activity(Label = "AndroidSfListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public static MainActivity Instance;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            Instance = this;

            SetContentView(Resource.Layout.Main);

            SetContentView(Resource.Layout.Main);
           
            var mainPage = new SfListViewPage().CreateFragment(this);
            FragmentManager
           .BeginTransaction()
           .Replace(Resource.Id.fragment_frame_layout, mainPage)
           .Commit();
        }
    }
}

