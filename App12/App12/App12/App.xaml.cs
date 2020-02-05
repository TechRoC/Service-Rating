using App12.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App12.Help;
using Rg.Plugins.Popup.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App12
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new Page3());
            //FinalPage();


        }
        private void FinalPage()
        {
            if (!string.IsNullOrEmpty(Settings.AccessToken))
            {
                MainPage = new NavigationPage(new MainPage());
            }

            else if (string.IsNullOrEmpty(Settings.Username) && string.IsNullOrEmpty(Settings.Password))
            {

                MainPage = new NavigationPage(new Page3());

            }
            else
            {
                MainPage = new NavigationPage(new Page3());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
