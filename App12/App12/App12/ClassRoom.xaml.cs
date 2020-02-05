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
    public partial class ClassRoom : ContentPage
    {
        public ClassRoom(int Class, string Projectordecision, string Projectorcomment, int Projectorrate, string Benchdecision, string Benchcomment, int  Benchrate, string Fandecision, string Fancomment, int Fanrate, string Lightdecision, string Lightcomment, int Lightrate, string Hygienedecision)
        {
            InitializeComponent();
            proscreen.Text = Projectordecision;
            procomment.Text = Projectorcomment;
            prorate.Text = Projectorrate.ToString();
        }
    }
}