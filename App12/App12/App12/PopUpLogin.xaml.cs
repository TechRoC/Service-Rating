using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Extensions;
using System.Threading;
using App12.Help;
using App12.Model;
using App12.Service;
using Xamarin.Essentials;

namespace App12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpLogin : PopupPage
    {
        //private WebApiService Services = new WebApiService();
        
        public Tutorial tutorialpage { get; set; }
        public Page3 ParentClass { set; get; }
        public string Username { get; set; }
        public string Password { get; set; }
        

        public PopUpLogin(Page3 parentClass)
        {
            ParentClass = parentClass;
            InitializeComponent();
            this.IsBusy = false;
           
           
        }
       
        public new bool IsAnimationEnabled { get; private set; } = true;
        protected override void OnAppearing()
        {
            base.OnAppearing();


            FrameContainer.HeightRequest = -1;
            if (!IsAnimationEnabled)
            {
                //CloseImage.Rotation = 0;
                //CloseImage.Scale = 1;
                //CloseImage.Opacity = 1;


                LoginButton.Scale = 1;
                LoginButton.Opacity = 1;


                UsernameEntry.TranslationX = PasswordEntry.TranslationX = 0;
                UsernameEntry.Opacity = PasswordEntry.Opacity = 1;


                return;
            }


            //CloseImage.Rotation = 380;
            //CloseImage.Scale = 0.3;
            //CloseImage.Opacity = 0;
            LoginButton.Scale = 0.3;
            LoginButton.Opacity = 0;
            UsernameEntry.TranslationX = PasswordEntry.TranslationX = -10;
            UsernameEntry.Opacity = PasswordEntry.Opacity = 0;
        }
       
        protected   override async void OnAppearingAnimationEnd()
        { 
            if (!IsAnimationEnabled)
                return;


            var translateLength = 400u;


            await Task.WhenAll(
            UsernameEntry.TranslateTo(0, 0, easing: Easing.SpringOut, length: translateLength),
            UsernameEntry.FadeTo(1),
            (new Func<Task>(async () =>
            {
                await Task.Delay(200);
                await Task.WhenAll(
    PasswordEntry.TranslateTo(0, 0, easing: Easing.SpringOut, length: translateLength),
    PasswordEntry.FadeTo(1));


            }))());


            await Task.WhenAll(
            CloseImage.FadeTo(1),
            CloseImage.ScaleTo(1, easing: Easing.SpringOut),
            CloseImage.RotateTo(0),
            LoginButton.ScaleTo(1),
            LoginButton.FadeTo(1));
        }


        protected override async void OnDisappearingAnimationBegin()
        {
            if (!IsAnimationEnabled)
                return;


            var taskSource = new TaskCompletionSource<bool>();


            var currentHeight = FrameContainer.Height;


            await Task.WhenAll(
            UsernameEntry.FadeTo(0),
            PasswordEntry.FadeTo(0),
            LoginButton.FadeTo(0));


            FrameContainer.Animate("HideAnimation", d =>
            {
                FrameContainer.HeightRequest = d;
            },
            start: currentHeight,
            end: 170,
            finished: async (d, b) =>
            {
                await Task.Delay(300);
                taskSource.TrySetResult(true);
            });


            await taskSource.Task;
        }


        private void OnCloseButtonTapped(object sender, EventArgs e)
        {
            CloseAllPopup();
        }


        protected override bool OnBackgroundClicked()
        {
            CloseAllPopup();


            return false;
        }


        private async void CloseAllPopup()
        {
            await Navigation.PopAllPopupAsync();
        }

        // private  void Button_Clicked(object sender, EventArgs e)
        //{

        //    var user = new LoginModel
        //    {
        //        Username = UsernameEntry.Text,
        //        Password = PasswordEntry.Text

        //    };
        //    var isValid = AreCredentialsCorrect(user);
        //    try
        //    {
        //        if (isValid)
        //        {

        //            this.IsBusy = true;
        //            DependencyService.Get<Message>().Shorttime("Login SuccessFull !!!!");

        //            //Navigation.PopAsync();
        //            PopupNavigation.Instance.PopAsync(true);
        //            MessagingCenter.Send<Page3>(ParentClass, "hi");
        //            if (tutorialpage == null)
        //            {

        //                tutorialpage = new Tutorial();
        //                Navigation.PushAsync(tutorialpage);
        //            }

        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        PopupNavigation.Instance.PopAsync(true);
        //    }


        //}

        // bool AreCredentialsCorrect (LoginModel user)
        //{
        //    return user.Username == Settings.Username && user.Password == Settings.Password;
        //}


        //private  void Button_Clicked(object sender, EventArgs e)
        //{


        //     PopupNavigation.Instance.PopAsync(true);
        //    if (!String.IsNullOrEmpty(Settings.AccessToken)){

        //        Navigation.PushAsync(new Tutorial());
        //    }



        //}
        private  void Button_Clicked(object sender, EventArgs e)
        {
           

             PopupNavigation.Instance.PopAsync(true);
            //if (!string.IsNullOrEmpty(Settings.Username1) && !string.IsNullOrEmpty(Settings.Password1) )
            //{

            //   Navigation.PushAsync(new Tutorial());
            ////}

            Settings.GeneralSettings = UsernameEntry.Text;

            Navigation.PushAsync(new Tutorial());
            



        }

    }
}