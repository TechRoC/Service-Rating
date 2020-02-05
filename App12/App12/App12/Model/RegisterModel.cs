using App12.Service;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using App12.Help;
using App12.Behaviors;

namespace App12.Model
{
    public class RegisterModel
    {
        EmailValidationBehavior email = new EmailValidationBehavior();
        WebApiService services = new WebApiService();
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string message { get; set; }
        
        
        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    if (String.IsNullOrEmpty(Email) || String.IsNullOrEmpty(Username) || String.IsNullOrEmpty(Password) || String.IsNullOrEmpty(ConfirmPassword))
                    {
                        DependencyService.Get<Message>().Shorttime("Please fill all the fields !!!!");
                    }
                    
                    else
                    {

                        DependencyService.Get<Message>().Longtime("Email has been sent to your account");
                        var isSuccess = await services.RegistrationAsync(Email, Username, Password, ConfirmPassword);
                        Settings.Username = Username;
                        Settings.Password = Password;
                        if (isSuccess)
                        {
                            DependencyService.Get<Message>().Longtime("Registration Successfully Done");
                        }
                        else
                        {
                            DependencyService.Get<Message>().Longtime("Oops Something Went Wrong !! Try Again");
                        }
                    }

                
                });
            }
        }
       
        public ICommand LogoutCommand
        {
            get
            {
                return new Command( () =>
                {
                    Settings.AccessToken = "";
                    Settings.Username = "";
                    Settings.Password = "";
                });
            }
        }
       
    }
}
