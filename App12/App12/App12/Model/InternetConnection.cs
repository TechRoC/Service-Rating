using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using Plugin.Toasts;

using Xamarin.Essentials;

using Xamarin.Forms;

namespace App12.Model
{
    class InternetConnection : INotifyPropertyChanged
    {
        public InternetConnection()

        {

            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;

        }



        ~InternetConnection()

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
    }
}
