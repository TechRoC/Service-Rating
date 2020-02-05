using App12.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using App12.Help;

namespace App12.Model
{
   public class LoginModel
    {
        private WebApiService Services = new WebApiService();
        private INavigation navigation;
        public string Username { get; set; }
        public string Password { get; set; }
        
        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
               {
                  
                   var accesstoken = await Services.LoginAsync(Username, Password);
                   Settings.AccessToken = accesstoken;
                   Settings.Username1 = Username;
                   Settings.Password1 = Password;
                   if (!string.IsNullOrEmpty(Settings.AccessToken))
                   {
                       //await navigation.PushAsync(new Tutorial());
                   }
               });
            }
        }
        public LoginModel()
        {
            Username = Settings.Username;
            Password = Settings.Password;
        }
    }
}
