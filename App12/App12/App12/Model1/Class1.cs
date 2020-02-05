using System;
using System.Collections.Generic;
using System.Text;

namespace App12.Model1
{
    public class RegisterBindingModel
    {
       
        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

       
        public string ConfirmPassword { get; set; }
    }
    public class ForgotPasswordViewModel
    {
        public string Email { get; set; }
    }
}
