using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DuplicateListViewPage1 : ContentPage
    {
        public ObservableCollection<Detailstuff> Items { get; set; }

        public DuplicateListViewPage1()
        {
            InitializeComponent();
            
            MessagingCenter.Subscribe<Data>(this, "AddItem", (sender) =>
            {
                

            });

            Items = new ObservableCollection<Detailstuff>();
            {
                Items.Add(new Detailstuff()
                 {
                     Name = "abc",
                     Source = "cheese_1.jpg",
                     Comment = "This is good",
                    
                 });
        }
			
			MyListView.ItemsSource = Items;
            MyListView.RefreshCommand = new Command(() =>
            {
                Fresh();
                MyListView.IsRefreshing = false;
            });
        }
        public void Fresh()
        {
            
            MyListView.ItemsSource = null;
            MyListView.ItemsSource = Items;

        }
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
    public class Data
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Source { get; set; }
    }
}
