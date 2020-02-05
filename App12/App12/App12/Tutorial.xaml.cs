using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tutorial : ContentPage
    {
        public MainPage mainpage { get; set; }
        public Tutorial()
        {

           
            InitializeComponent();
            lblClickFunc();
            NavigationPage.SetHasNavigationBar(this, false);

            var menu = new List<Detailstuff>();

            menu.Add(new Detailstuff()
            {
                TitleName = "Tip 1:- Here You can view statistics",
                Source = "Statistics.png",
               

            });
            menu.Add(new Detailstuff()
            {
                TitleName = "Tip 2:-Feedbacks related to Reading Room are here checkout!!",
                Source = "reading.png",
               
            });
            menu.Add(new Detailstuff()
            {
                TitleName = "Tip 3:-Feedbacks related to Library are here checkout!!",
                Source = "Library12.png",
                
            });
            //menuList.Add(new MasterPageItem()
            //{
            //    Title = "Main",
            //    Icon = "icon.png",
            //    TargetType = typeof(TestPage1)
            //});
            // Setting our list to be ItemSource for ListView in MainPage.xaml  
            MainCarouselView.ItemsSource = menu;
        }

        void lblClickFunc()
        {
            lblClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {

                    
                   if (mainpage ==  null)
                    {
                        mainpage = new MainPage();
                        Navigation.PushAsync(mainpage);
                    }
                        
                })
            });
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
        //private void Skip_Clicked(object sender, EventArgs e)
        //{
        //    DependencyService.Get<Message>().Shorttime("Here We go !!!!");
        //    Navigation.InsertPageBefore(new MainPage(), this);
        //    Navigation.PopToRootAsync();
        //}
    }
}