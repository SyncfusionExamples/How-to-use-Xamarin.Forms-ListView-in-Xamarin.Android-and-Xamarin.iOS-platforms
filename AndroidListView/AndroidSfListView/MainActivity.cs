using Android.App;
using Android.OS;
using Xamarin.Forms;

using Xamarin.Forms.Platform.Android;
using Android.Support.V7.App;

namespace AndroidSfListView
{
    [Activity(Label = "AndroidSfListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        public static MainActivity Instance;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            Instance = this;

            SetContentView(Resource.Layout.Main);

            var mainPage = new SfListViewPage().CreateSupportFragment(this);
            SupportFragmentManager
             .BeginTransaction()
             .Replace(Resource.Id.fragment_frame_layout, mainPage)
             .Commit();
        }
    }
}

