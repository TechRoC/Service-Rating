using System;
using System.ComponentModel;

using System.Runtime.CompilerServices;

using System.Threading.Tasks;

using Xamarin.Forms.Extended;



namespace App12.Model
{

    public class MainViewModel : INotifyPropertyChanged

    {

        private bool _isBusy;

        private const int PageSize = 10;

        readonly DataService _dataService = new DataService();



        public InfiniteScrollCollection<Detailstuff> Data { get; }



        public bool IsBusy

        {

            get => _isBusy;

            set

            {

                _isBusy = value;

                OnPropertyChanged();

            }

        }



        public MainViewModel()

        {

            Data = new InfiniteScrollCollection<Detailstuff>

            {

                OnLoadMore = async () =>

                {

                    IsBusy = true;



                    // load the next page

                    var page = Data.Count / PageSize;



                    var items = await _dataService.GetItemsAsync(page, PageSize);



                    IsBusy = false;



                    // return the items that need to be added

                    return items;

                },

                OnCanLoadMore = () =>

                {

                    return Data.Count < 44;

                }

            };



            DownloadDataAsync();

        }



        private async Task DownloadDataAsync()

        {

            var items = await _dataService.GetItemsAsync(pageIndex: 0, pageSize: PageSize);



            Data.AddRange(items);

        }



        public event PropertyChangedEventHandler PropertyChanged;



        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)

        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

    }

}
