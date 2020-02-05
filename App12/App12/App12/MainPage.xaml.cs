using System;
using System.Collections.Generic;
using System.Linq;
using App12.Help;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace App12
{
    public partial class MainPage : MasterDetailPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            User.Text = Settings.GeneralSettings;
            NavigationPage.SetHasNavigationBar(this, false);
            
           
            var menu = new List<Detailstuff>();
              
            menu.Add(new Detailstuff()
            {
                TitleName = "Home",
                Source = "Home.png",
                Access = typeof(HomePage),
                
            });
            menu.Add(new Detailstuff()
            {
                TitleName = "Comments & suggestions",
                Source = "comment.png",
                Access = typeof(Page1)
            });
            menu.Add(new Detailstuff()
            {
                TitleName = "Ratings & Reviews",
                Source = "abouticon.png",
                Access = typeof(Page2),
                Separator=true
            });
            menu.Add(new Detailstuff()
            {
                TitleName = "ClassRoom",
                Source = "abouticon.png",
                Access = typeof(ClassRoom)
            });
            menu.Add(new Detailstuff()
            {
                TitleName = "Main",
                Source = "abouticon.png",
                Access = typeof(Library)
            });
            menu.Add(new Detailstuff()
            {
                TitleName = "Main",
                Source = "abouticon.png",
                Access = typeof(ITLabs)
            });
            menu.Add(new Detailstuff()
            {
                TitleName = "Main",
                Source = "abouticon.png",
                Access = typeof(ReadingRoom)
            });
            // Setting our list to be ItemSource for ListView in MainPage.xaml  
            navigationDrawerList.ItemsSource = menu;
            

            // Initial navigation, this can be used for our home page  
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));

        }

       

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Detailstuff)e.SelectedItem;
         
           
            Type page = item.Access;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));

            IsPresented = false;
            Detailstuff set = e.SelectedItem as Detailstuff;
           

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
    }
}
