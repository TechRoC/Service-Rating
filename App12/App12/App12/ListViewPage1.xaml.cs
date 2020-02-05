using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage1 : ContentPage, INotifyPropertyChanged
    {
        private  Detailstuff _oldProduct;
        public List<Detailstuff> Items { get; set; }
        public uint AnimationDuration { get;  set; }
        

        public ListViewPage1()
        {
         
        AnimationDuration = 150;
            InitializeComponent();


            //Items = new List<Detailstuff>();
            //Items.Add(new Detailstuff()
            //{
            // Name="abc",
            //   Source="cheese_1.jpg" ,Comment ="This is good", Rating= true   
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "efg",
            //    Source = "cheese_2.jpg",
            //    Comment = "This is good",
            //    Rating = true,
            //    Save = false
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "hij",
            //    Source = "cheese_3.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "Lmn",
            //    Source = "cheese_4.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "abc",
            //    Source = "cheese_1.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "efg",
            //    Source = "cheese_2.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "hij",
            //    Source = "cheese_3.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "Lmn",
            //    Source = "cheese_4.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "abc",
            //    Source = "cheese_1.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "efg",
            //    Source = "cheese_2.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "hij",
            //    Source = "cheese_3.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "Lmn",
            //    Source = "cheese_4.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "abc",
            //    Source = "cheese_1.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "efg",
            //    Source = "cheese_2.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "hij",
            //    Source = "cheese_3.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //Items.Add(new Detailstuff()
            //{
            //    Name = "Lmn",
            //    Source = "cheese_4.jpg",
            //    Comment = "This is good",
            //    Rating = true
            //});
            //MyListView.ItemsSource = Items;
            //MyListView.RefreshCommand = new Command(() =>
            //{
            //    Fresh();
            //    MyListView.IsRefreshing = false;
            //});

        }

       

        public void Fresh()
        {
            Items.Add(new Detailstuff()
            {
                Name = "Lmn",
                Comment = "This is good",
                Rating = true
            });
            MyListView.ItemsSource = null;
            MyListView.ItemsSource = Items;

        }

       

        private static bool isfabopen;
        private async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as DataService;
            var product = e.Item as Detailstuff;
            await Navigation.PushAsync(new ClassRoom(product.Class, product.Projectordecision, product.Projectorcomment, product.Projectorrate, product.Benchdecision, product.Benchcomment, product.Benchrate, product.Fandecision, product.Fancomment, product.Fanrate, product.Lightdecision, product.Lightcomment, product.Lightrate, product.Hygienedecision));
          
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            




        }
    //    string _name;
    //    public string Name
    //    {
    //        get
    //        {
    //            return _name;
    //        }
    //        set
    //        {
    //            _name = value;
    //            OnPropertyChanged();
    //        }
    //    }
    //    string _comment;
    //    public string Comment
    //    {
    //        get
    //        {
    //            return _comment;
    //        }
    //        set
    //        {
    //            _comment = value;
    //            OnPropertyChanged(); 
    //}
    //    }
   
        public event PropertyChangedEventHandler PropertyChanged;
        protected override void OnPropertyChanged([CallerMemberName]string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Main_Clicked(object sender, System.EventArgs e)
        {
            //if (!isfabopen)
            //    showFabMenu();
            //else
            //    closeFabMenu();
           
            Navigation.PushAsync(new DuplicateListViewPage1());
           

           
        }

        private void closeFabMenu()
        {
            isfabopen = false;
            subMain.IsVisible = false;
            Main.Rotation = 0f;
        }

        private void showFabMenu()
        {
            isfabopen = true;
            subMain.IsVisible = true;
            Main.Rotation = 135f;
        }

        private void SubMain_Clicked(object sender, EventArgs e)
        {
            SnackB.Message = "Unselect All The Items......";
           
            
            SnackB.IsOpen = !SnackB.IsOpen;
           
            
        }

      

       
    }
}
