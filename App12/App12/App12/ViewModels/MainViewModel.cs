using App12.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App12.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<Detailstuff> _classRoomList;

        public List<Detailstuff> ClassRoomList
        {
            get { return _classRoomList; }
            set
            {
                _classRoomList = value;
                OnPropertyChanged();
            }
        }
        private List<Detailstuff> _libraryList;

        public List<Detailstuff> LibraryList
        {
            get { return _libraryList; }
            set
            {
                _libraryList = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            InitializeDataAsync();
        }
        private async Task InitializeDataAsync()
        {
            var libraryServices = new LibraryServices();
            var classroomServices = new ClassRoomServices();
            ClassRoomList = await classroomServices.GetClassRoomAsync();
            LibraryList = await libraryServices.GetLibraryAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
