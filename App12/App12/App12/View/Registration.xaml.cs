using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
            lblClickFunc();
           
        }
        void lblClickFunc()
        {
            Pagei.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {



                    Navigation.PopAsync();


                })
            });
        }
       

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            register.BackgroundColor = Color.MediumPurple;
            

        }
    }
}