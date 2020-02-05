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
    public partial class LibraryList : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public LibraryList()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };
			
			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           
            var product = e.Item as LibraryData;
            await Navigation.PushAsync(new Library());
            //await Navigation.PushAsync(new Library(product.Bookdecision, product.Bookname, product.Author, product.Department, product.Pcdecision, product.Pcnumber, product.Problem, product.pcrate, product.Fandecision, product.Fancomment, product.Fanrate, product.Benchdecision, product.Benchcomment, product.Benchrate,product.Hygienedecision,product.Hygienecomment,product.Hygienerate product.Hygienedecision));
        }
    }
}
