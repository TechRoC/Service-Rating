using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Xfx.Controls.Droid;
using Xfx;
using Android.Support.Design.Widget;
using Android.Animation;
using SuaveControls;
using CarouselView.FormsPlugin.Android;
using Xamarin.Forms;
using Android.Content;

namespace App12.Droid
{
    [Activity(Label = "App12", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.Orientation , ScreenOrientation =ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private static bool isFabOpen;
        private FloatingActionButton fabcake;
        private FloatingActionButton fab_pencil;
        private FloatingActionButton fabmain;
        
        static TextView actiontext;

        private long backPressedTime;
        bool doubleBackToExitPressedOnce = false;
      
      
        protected override void OnCreate(Bundle savedInstanceState)
        {
            


        TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
             

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            XfxControls.Init();

            CarouselViewRenderer.Init();


            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //int uiOptions = (int)Window.DecorView.SystemUiVisibility;
            ////uiOptions |= (int)SystemUiFlags.LowProfile;
            //uiOptions |= (int)SystemUiFlags.HideNavigation;
            //uiOptions |= (int)SystemUiFlags.ImmersiveSticky;
            //Window.DecorView.SystemUiVisibility = (StatusBarVisibility)uiOptions;

           

            LoadApplication(new App());
        }
       //private void CarouselViewControls()
       // {
       //     CarouselViewRenderer.Init();
       // }

     

    }
}