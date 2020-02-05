using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Setting : ContentPage
    {
        public MainPage mainpage { get; set; }
        public Setting()
        {
            InitializeComponent();
        }
        //protected override bool OnBackButtonPressed()
        //{
        //    var exitpages = Navigation.NavigationStack.ToList();
        //    foreach (var page in exitpages)
        //    {
        //        if (page != this)
        //        {
        //            Navigation.RemovePage(page);
        //        }
        //    }
        //    if (mainpage == null)
        //    {
        //        mainpage = new MainPage();
        //        Navigation.PushAsync(mainpage);
        //    }

        //    return base.OnBackButtonPressed();
        //}
    } 
}