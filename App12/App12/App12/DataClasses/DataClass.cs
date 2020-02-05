using System;
using System.Collections.Generic;
using System.Text;


namespace App12.DataClasses
{
    public class ClassRoom
    {
        public string  Id { get; set; }
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
    }
}
