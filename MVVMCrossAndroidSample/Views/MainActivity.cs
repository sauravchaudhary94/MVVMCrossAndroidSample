using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace MVVMCrossAndroidSample.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public sealed class MainActivity : MvxActivity<MainViewModel>
    {
        //Test Project for MVVMCross
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }
}