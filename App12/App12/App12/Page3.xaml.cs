using Rg.Plugins.Popup.Services;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App12.View;
using Plugin.Toasts;
using System.ComponentModel;
using Xamarin.Essentials;

namespace App12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage, INotifyPropertyChanged
    {
        
        public PopUpLogin popuploginpage { get; set; }

        public Registration registration { get; set; }
        public Page3()
        {
           
            InitializeComponent();
           
            lblClickFunc();
            NavigationPage.SetHasNavigationBar(this, false);
            MessagingCenter.Subscribe<Page3>(this, "hi", (sender) =>
            {
                popuploginpage = null;
            });
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }
        ~Page3()

        {

            Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;

        }
        public event PropertyChangedEventHandler PropertyChanged;



        void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)

        {

            if (e.NetworkAccess != NetworkAccess.Internet)
            {

                DependencyService.Get<IToastNotificator>().Notify(new NotificationOptions()

                {

                    Description = "Oops, looks like you don't have internet connection :(",

                    Title = "Connection lost"

                });

            }

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
           
                
                //if(popuploginpage==null)
                //{
                //    popuploginpage = new PopUpLogin(this);
                //        PopupNavigation.Instance.PushAsync(popuploginpage);
                //}

                if (popuploginpage == null)
                {

                    popuploginpage = new PopUpLogin(this);
                    PopupNavigation.Instance.PushAsync(popuploginpage);
                        if(popuploginpage != null)
                {
                    popuploginpage = null;
                }
                }
               


                //DisplayAlert("Login", "Login Successfull", "Ok");
                //Navigation.InsertPageBefore(new MainPage(), this);
                //Navigation.PopToRootAsync();
                //Application.Current.MainPage = new MainPage();

            }
        void lblClickFunc()
        {
            SignUp.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {


                    
                        Navigation.PushAsync(new Registration());
                

                })
            });
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgottenPassword());
        }


        //protected override bool OnBackButtonPressed()
        //{

        //    if (popuploginpage != null)
        //    {
        //        PopupNavigation.Instance.PopAsync(true);
        //        popuploginpage = null;
        //    }

        //    return base.OnBackButtonPressed();

        //}


    }
}