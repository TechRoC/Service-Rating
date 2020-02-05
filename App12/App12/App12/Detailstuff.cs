using System;
using System.ComponentModel;
using System.Drawing;

namespace App12
{
    public class Detailstuff : INotifyPropertyChanged
    {
        Color labelColor;
        public Color LabelColor
        {
            set
            {
                labelColor = value;
                OnPopertyChanged("LabelColor");
            }
            get
            {
                return labelColor;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPopertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string TitleName
        {
            get;
            set;
        }
        public string Source
        {
            get;
            set;
        }
        public Type Access
        {
            get;
            set;
        }
        public bool Separator
        {
            get;
            set;
        }

        public bool Rating
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Comment
        {
            get;
            set;
        }

        public bool Save
        {
            get;
            set;
        }
        //classroom
        public string Id { get; set; }
        public int Class { get; set; }
        public string Projectordecision { get; set; }
        public int Projector { get; set; }
        public int Projectorscreen { get; set; }
        public string Projectorcomment { get; set; }
        public int Projectorrate { get; set; }
        public string Benchdecision { get; set; }
        public string Benchcomment { get; set; }
        public int Benchrate { get; set; }
        public string Fandecision { get; set; }
        public string Fancomment { get; set; }
        public int Fanrate { get; set; }
        public string Lightdecision { get; set; }
        public string Lightcomment { get; set; }
        public int Lightrate { get; set; }
        public string Hygienedecision { get; set; }
        public int Overallrating { get; set; }

        //library
       
        public string Bookdecision { get; set; }
        public string Bookname { get; set; }
        public string Author { get; set; }
        public string Department { get; set; }
        public string Pcdecision { get; set; }
        public int Pcnumber { get; set; }
        public string Problem { get; set; }
        public int pcrate { get; set; }
        public string Fandecision1 { get; set; }
        public string Fancomment1 { get; set; }
        public int Fanrate1 { get; set; }
        public string Benchdecision1 { get; set; }
        public string Benchcomment1 { get; set; }
        public int Benchrate1 { get; set; }
        public string Hygienedecision1 { get; set; }
        public string Hygienecomment { get; set; }
        public int Hygienerate { get; set; }
        public int Overallrating1 { get; set; }

    }

}
