using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App12.Help;

namespace App12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

        }


        protected override bool OnBackButtonPressed()
        {
            var exitpages = Navigation.NavigationStack.ToList();
            foreach (var page in exitpages)
            {
                if (page != this)
                {
                    Navigation.RemovePage(page);
                }
            }

            return base.OnBackButtonPressed();
        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
            OnBackButtonPressed();
        }

        public ICommand LogoutCommand
        {
            get
            {
                return new Command(() =>
                {
                    Settings.AccessToken = "";
                    Settings.Username = "";
                    Settings.Password = "";
                });
            }
        }

    }
}