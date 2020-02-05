using App12.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App12.Model
{
    class ForgotPasswordModel
    {
        WebApiService services = new WebApiService();
        public string Email { get; set; }
        public ICommand ForgotCommand
        {
            get
            {
                return new Command(async () =>
                {
                    if (String.IsNullOrEmpty(Email) )
                    {
                        DependencyService.Get<Message>().Shorttime("Please fill  the field !!!!");
                    }

                    else
                    {


                        var isSuccess = await services.ForgotPasswordAsync(Email);
                        if (isSuccess)
                        {
                            DependencyService.Get<Message>().Longtime("Password Successfully Changed !!!!");
                        }
                        else
                        {
                            DependencyService.Get<Message>().Longtime("Oops !! Something went wrong try again");
                        }
                       
                        
                    }


                });
            }
        }
       
    }
}
