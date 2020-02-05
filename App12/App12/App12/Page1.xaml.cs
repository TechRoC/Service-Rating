using Microcharts;
using SkiaSharp;
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
    public partial class Page1 : ContentPage
    {
        List<Microcharts.Entry> entries = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(100)
                {
                    Label = "Jan",
                    ValueLabel = "100",
                    Color = SKColor.Parse("#FF0000")
                },
                 new Microcharts.Entry(648)
                {
                    Label = "Feb",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#7CFC00")
                },
                      new Microcharts.Entry(-500)
                {
                    Label = "March",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF4500")
                },
                     new Microcharts.Entry(765)
                {
                    Label = "April",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#008000")
                },
                       new Microcharts.Entry(675)
                {
                    Label = "May",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FFC0CB")
                },
                         new Microcharts.Entry(567)
                {
                    Label = "June",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF1493")
                }
            };
        List<Microcharts.Entry> ent = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(700)
                {
                    Label = "Jan",
                    ValueLabel = "100",
                    Color = SKColor.Parse("#FF0000")
                },
                 new Microcharts.Entry(368)
                {
                    Label = "February",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#7CFC00")
                },
                   new Microcharts.Entry(30)
                {
                    Label = "March",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF4500")
                },
                     new Microcharts.Entry(30)
                {
                    Label = "April",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#008000")
                },
                       new Microcharts.Entry(213)
                {
                    Label = "May",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FFC0CB")
                },
                         new Microcharts.Entry(32)
                {
                    Label = "June",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF1493")
                }
        };
        List<Microcharts.Entry> ent3 = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(123)
                {
                    Label = "Jan",
                    ValueLabel = "100",
                    Color = SKColor.Parse("#FF0000")
                },
                 new Microcharts.Entry(546)
                {
                    Label = "February",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#7CFC00")
                },
                   new Microcharts.Entry(34)
                {
                    Label = "March",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF4500")
                },
                     new Microcharts.Entry(230)
                {
                    Label = "April",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#008000")
                },
                       new Microcharts.Entry(249)
                {
                    Label = "May",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FFC0CB")
                },
                         new Microcharts.Entry(45)
                {
                    Label = "June",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF1493")
                }
        };
        List<Microcharts.Entry> ent4 = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(435)
                {
                    Label = "Jan",
                    ValueLabel = "100",
                    Color = SKColor.Parse("#FF0000")
                },
                 new Microcharts.Entry(456)
                {
                    Label = "February",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#7CFC00")
                },
                   new Microcharts.Entry(456)
                {
                    Label = "March",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF4500")
                },
                     new Microcharts.Entry(65)
                {
                    Label = "April",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#008000")
                },
                       new Microcharts.Entry(658)
                {
                    Label = "May",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FFC0CB")
                },
                         new Microcharts.Entry(647)
                {
                    Label = "June",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF1493")
                }
        };
        List<Microcharts.Entry> ent5 = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(323)
                {
                    Label = "Jan",
                    ValueLabel = "100",
                    Color = SKColor.Parse("#FF0000")
                },
                 new Microcharts.Entry(42)
                {
                    Label = "February",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#7CFC00")
                },
                   new Microcharts.Entry(65)
                {
                    Label = "March",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF4500")
                },
                     new Microcharts.Entry(542)
                {
                    Label = "April",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#008000")
                },
                       new Microcharts.Entry(218)
                {
                    Label = "May",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FFC0CB")
                },
                         new Microcharts.Entry(321)
                {
                    Label = "June",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF1493")
                }
        };
        List<Microcharts.Entry> ent6 = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(231)
                {
                    Label = "Jan",
                    ValueLabel = "100",
                    Color = SKColor.Parse("#FF0000")
                },
                 new Microcharts.Entry(654)
                {
                    Label = "February",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#7CFC00")
                },
                   new Microcharts.Entry(973)
                {
                    Label = "March",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF4500")
                },
                     new Microcharts.Entry(121)
                {
                    Label = "April",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#008000")
                },
                       new Microcharts.Entry(432)
                {
                    Label = "May",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FFC0CB")
                },
                         new Microcharts.Entry(432)
                {
                    Label = "June",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF1493")
                }
        };
        List<Microcharts.Entry> ent7 = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(321)
                {
                    Label = "Jan",
                    ValueLabel = "100",
                    Color = SKColor.Parse("#FF0000")
                },
                 new Microcharts.Entry(420)
                {
                    Label = "February",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#7CFC00")
                },
                   new Microcharts.Entry(429)
                {
                    Label = "March",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF4500")
                },
                     new Microcharts.Entry(543)
                {
                    Label = "April",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#008000")
                },
                       new Microcharts.Entry(-300)
                {
                    Label = "May",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FFC0CB")
                },
                         new Microcharts.Entry(452)
                {
                    Label = "June",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF1493")
                }
        };
        List<Microcharts.Entry> ent8 = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(500)
                {
                    Label = "Jan",
                    ValueLabel = "100",
                    Color = SKColor.Parse("#FF0000")
                },
                 new Microcharts.Entry(100)
                {
                    Label = "February",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#7CFC00")
                },
                   new Microcharts.Entry(-300)
                {
                    Label = "March",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF4500")
                },
                     new Microcharts.Entry(345)
                {
                    Label = "April",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#008000")
                },
                       new Microcharts.Entry(675)
                {
                    Label = "May",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FFC0CB")
                },
                         new Microcharts.Entry(230)
                {
                    Label = "June",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF1493")
                }
        };
        List<Microcharts.Entry> ent9 = new List<Microcharts.Entry>
            {
                new Microcharts.Entry(200)
                {
                    Label = "Jan",
                    ValueLabel = "100",
                    Color = SKColor.Parse("#FF0000")
                },
                 new Microcharts.Entry(300)
                {
                    Label = "February",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#7CFC00")
                },
                   new Microcharts.Entry(535)
                {
                    Label = "March",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF4500")
                },
                     new Microcharts.Entry(12)
                {
                    Label = "April",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#008000")
                },
                       new Microcharts.Entry(-200)
                {
                    Label = "May",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FFC0CB")
                },
                         new Microcharts.Entry(600)
                {
                    Label = "June",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#FF1493")
                }
        };
      
        public Page1()
        {
            InitializeComponent();
            picker1.Items.Add("BarChart");
            picker1.Items.Add("LineChart");
            picker1.Items.Add("PointChart");
            picker1.Items.Add("RadialGaugeChart");
            picker1.Items.Add("DonutChart");
            picker1.Items.Add("RadarChart");
            Chart1.Chart = new  BarChart  { Entries = entries};
            Chart2.Chart = new BarChart { Entries = ent };
            Chart3.Chart = new BarChart { Entries = ent3};
            Chart4.Chart = new BarChart { Entries = ent4 };
            Chart5.Chart = new BarChart { Entries = ent5 };
            Chart6.Chart = new BarChart { Entries = ent6 };
            Chart7.Chart = new BarChart { Entries = ent7 };
            Chart8.Chart = new BarChart { Entries = ent8 };
            Chart9.Chart = new BarChart { Entries = ent9 };
            Chart11.Chart = new LineChart { Entries = entries };
            Chart21.Chart = new LineChart { Entries = ent };
            Chart31.Chart = new LineChart { Entries = ent3 };
            Chart41.Chart = new LineChart { Entries = ent4 };
            Chart51.Chart = new LineChart { Entries = ent5 };
            Chart61.Chart = new LineChart { Entries = ent6 };
            Chart71.Chart = new LineChart { Entries = ent7 };
            Chart81.Chart = new LineChart { Entries = ent8 };
            Chart91.Chart = new LineChart { Entries = ent9 };
            //PointChart
            Chart12.Chart = new PointChart { Entries = entries };
            Chart22.Chart = new PointChart { Entries = ent };
            Chart32.Chart = new PointChart { Entries = ent3 };
            Chart42.Chart = new PointChart { Entries = ent4 };
            Chart52.Chart = new PointChart { Entries = ent5 };
            Chart62.Chart = new PointChart { Entries = ent6 };
            Chart72.Chart = new PointChart { Entries = ent7 };
            Chart82.Chart = new PointChart { Entries = ent8 };
            Chart92.Chart = new PointChart { Entries = ent9 };
            //RadialGaugeChart
            Chart13.Chart = new RadialGaugeChart { Entries = entries };
            Chart23.Chart = new RadialGaugeChart { Entries = ent };
            Chart33.Chart = new RadialGaugeChart { Entries = ent3 };
            Chart43.Chart = new RadialGaugeChart { Entries = ent4 };
            Chart53.Chart = new RadialGaugeChart { Entries = ent5 };
            Chart63.Chart = new RadialGaugeChart { Entries = ent6 };
            Chart73.Chart = new RadialGaugeChart { Entries = ent7 };
            Chart83.Chart = new RadialGaugeChart { Entries = ent8 };
            Chart93.Chart = new RadialGaugeChart { Entries = ent9 };
            //DonutChart
            Chart14.Chart = new DonutChart { Entries = entries };
            Chart24.Chart = new DonutChart { Entries = ent };
            Chart34.Chart = new DonutChart { Entries = ent3 };
            Chart44.Chart = new DonutChart { Entries = ent4 };
            Chart54.Chart = new DonutChart { Entries = ent5 };
            Chart64.Chart = new DonutChart { Entries = ent6 };
            Chart74.Chart = new DonutChart { Entries = ent7 };
            Chart84.Chart = new DonutChart { Entries = ent8 };
            Chart94.Chart = new DonutChart { Entries = ent9 };
            //RadarChart
            
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Setting());
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Main_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("heloo", "hello", "hello");
        }

        private void Picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
           var eg = picker1.Items[picker1.SelectedIndex];
            if(eg== "BarChart")
            {
                Chart1.IsVisible = true;
                Chart2.IsVisible = true;
                Chart3.IsVisible = true;
                Chart4.IsVisible = true;
                Chart5.IsVisible = true;
                Chart6.IsVisible = true;
                Chart7.IsVisible = true;
                Chart8.IsVisible = true;
                Chart9.IsVisible = true;
                InFrastructure.IsVisible = true;
                ClassRooms.IsVisible = true;
                Library.IsVisible = true;
                ITLab.IsVisible = true;
                PCBLabs.IsVisible = true;
                CommonRooms.IsVisible = true;
                ReadingRooms.IsVisible = true;
                ActivityRooms.IsVisible = true;
                Gym.IsVisible = true ;

                //LineChart
                Chart11.IsVisible = false;
                Chart21.IsVisible = false;
                Chart31.IsVisible = false;
                Chart41.IsVisible = false;
                Chart51.IsVisible = false;
                Chart61.IsVisible = false;
                Chart71.IsVisible = false;
                Chart81.IsVisible = false;
                Chart91.IsVisible = false;
                InFrastructure1.IsVisible = false;
                ClassRooms1.IsVisible = false;
                Library1.IsVisible = false;
                ITLab1.IsVisible = false;
                PCBLabs1.IsVisible = false;
                CommonRooms1.IsVisible = false;
                ReadingRooms1.IsVisible = false;
                ActivityRooms1.IsVisible = false;
                Gym1.IsVisible = false;
                //PointChart
                Chart12.IsVisible = false;
                Chart22.IsVisible = false;
                Chart32.IsVisible = false;
                Chart42.IsVisible = false;
                Chart52.IsVisible = false;
                Chart62.IsVisible = false;
                Chart72.IsVisible = false;
                Chart82.IsVisible = false;
                Chart92.IsVisible = false;
                InFrastructure11.IsVisible = false;
                ClassRooms11.IsVisible = false;
                Library11.IsVisible = false;
                ITLab11.IsVisible = false;
                PCBLabs11.IsVisible = false;
                CommonRooms11.IsVisible = false;
                ReadingRooms11.IsVisible = false;
                ActivityRooms11.IsVisible = false;
                Gym11.IsVisible = false;
                //GaugeRadialChart
                Chart13.IsVisible = false;
                Chart23.IsVisible = false;
                Chart33.IsVisible = false;
                Chart43.IsVisible = false;
                Chart53.IsVisible = false;
                Chart63.IsVisible = false;
                Chart73.IsVisible = false;
                Chart83.IsVisible = false;
                Chart93.IsVisible = false;
                InFrastructure12.IsVisible = false;
                ClassRooms12.IsVisible = false;
                Library12.IsVisible = false;
                ITLab12.IsVisible = false;
                PCBLabs12.IsVisible = false;
                CommonRooms12.IsVisible = false;
                ReadingRooms12.IsVisible = false;
                ActivityRooms12.IsVisible = false;
                Gym12.IsVisible = false;
                //DonutChart
                Chart14.IsVisible = false;
                Chart24.IsVisible = false;
                Chart34.IsVisible = false;
                Chart44.IsVisible = false;
                Chart54.IsVisible = false;
                Chart64.IsVisible = false;
                Chart74.IsVisible = false;
                Chart84.IsVisible = false;
                Chart94.IsVisible = false;
                InFrastructure13.IsVisible = false;
                ClassRooms13.IsVisible = false;
                Library13.IsVisible = false;
                ITLab13.IsVisible = false;
                PCBLabs13.IsVisible = false;
                CommonRooms13.IsVisible = false;
                ReadingRooms13.IsVisible = false;
                ActivityRooms13.IsVisible = false;
                Gym13.IsVisible = false;
                //RadarChart
            


            }
            if (eg == "LineChart")
            {
                Chart1.IsVisible = false;
                Chart2.IsVisible = false;
                Chart3.IsVisible = false;
                Chart4.IsVisible = false;
                Chart5.IsVisible = false;
                Chart6.IsVisible = false;
                Chart7.IsVisible = false;
                Chart8.IsVisible = false;
                Chart9.IsVisible = false;
                InFrastructure.IsVisible = false;
                ClassRooms.IsVisible = false;
                Library.IsVisible = false;
                ITLab.IsVisible = false;
                PCBLabs.IsVisible = false;
                CommonRooms.IsVisible = false;
                ReadingRooms.IsVisible = false;
                ActivityRooms.IsVisible = false;
                Gym.IsVisible = false;

                //LineChart
                Chart11.IsVisible = true;
                Chart21.IsVisible = true;
                Chart31.IsVisible = true;
                Chart41.IsVisible = true;
                Chart51.IsVisible = true;
                Chart61.IsVisible = true;
                Chart71.IsVisible = true;
                Chart81.IsVisible = true;
                Chart91.IsVisible = true;
                InFrastructure1.IsVisible = true;
                ClassRooms1.IsVisible = true;
                Library1.IsVisible = true;
                ITLab1.IsVisible = true;
                PCBLabs1.IsVisible = true;
                CommonRooms1.IsVisible = true;
                ReadingRooms1.IsVisible = true;
                ActivityRooms1.IsVisible = true;
                Gym1.IsVisible = true;
                //PointChart
                Chart12.IsVisible = false;
                Chart22.IsVisible = false;
                Chart32.IsVisible = false;
                Chart42.IsVisible = false;
                Chart52.IsVisible = false;
                Chart62.IsVisible = false;
                Chart72.IsVisible = false;
                Chart82.IsVisible = false;
                Chart92.IsVisible = false;
                InFrastructure11.IsVisible = false;
                ClassRooms11.IsVisible = false;
                Library11.IsVisible = false;
                ITLab11.IsVisible = false;
                PCBLabs11.IsVisible = false;
                CommonRooms11.IsVisible = false;
                ReadingRooms11.IsVisible = false;
                ActivityRooms11.IsVisible = false;
                Gym11.IsVisible = false;
                //GaugeRadialChart
                Chart13.IsVisible = false;
                Chart23.IsVisible = false;
                Chart33.IsVisible = false;
                Chart43.IsVisible = false;
                Chart53.IsVisible = false;
                Chart63.IsVisible = false;
                Chart73.IsVisible = false;
                Chart83.IsVisible = false;
                Chart93.IsVisible = false;
                InFrastructure12.IsVisible = false;
                ClassRooms12.IsVisible = false;
                Library12.IsVisible = false;
                ITLab12.IsVisible = false;
                PCBLabs12.IsVisible = false;
                CommonRooms12.IsVisible = false;
                ReadingRooms12.IsVisible = false;
                ActivityRooms12.IsVisible = false;
                Gym12.IsVisible = false;
                //Donut
                Chart14.IsVisible = false;
                Chart24.IsVisible = false;
                Chart34.IsVisible = false;
                Chart44.IsVisible = false;
                Chart54.IsVisible = false;
                Chart64.IsVisible = false;
                Chart74.IsVisible = false;
                Chart84.IsVisible = false;
                Chart94.IsVisible = false;
                InFrastructure13.IsVisible = false;
                ClassRooms13.IsVisible = false;
                Library13.IsVisible = false;
                ITLab13.IsVisible = false;
                PCBLabs13.IsVisible = false;
                CommonRooms13.IsVisible = false;
                ReadingRooms13.IsVisible = false;
                ActivityRooms13.IsVisible = false;
                Gym13.IsVisible = false;
                //RadarChart
               
            }
            if (eg == "PointChart")
            {
                //BarChart
                Chart1.IsVisible = false;
                Chart2.IsVisible = false;
                Chart3.IsVisible = false;
                Chart4.IsVisible = false;
                Chart5.IsVisible = false;
                Chart6.IsVisible = false;
                Chart7.IsVisible = false;
                Chart8.IsVisible = false;
                Chart9.IsVisible = false;
                InFrastructure.IsVisible = false;
                ClassRooms.IsVisible = false;
                Library.IsVisible = false;
                ITLab.IsVisible = false;
                PCBLabs.IsVisible = false;
                CommonRooms.IsVisible = false;
                ReadingRooms.IsVisible = false;
                ActivityRooms.IsVisible = false;
                Gym.IsVisible = false;
                //LineChart
                Chart11.IsVisible = false;
                Chart21.IsVisible = false;
                Chart31.IsVisible = false;
                Chart41.IsVisible = false;
                Chart51.IsVisible = false;
                Chart61.IsVisible = false;
                Chart71.IsVisible = false;
                Chart81.IsVisible = false;
                Chart91.IsVisible = false;
                InFrastructure1.IsVisible = false;
                ClassRooms1.IsVisible = false;
                Library1.IsVisible = false;
                ITLab1.IsVisible = false;
                PCBLabs1.IsVisible = false;
                CommonRooms1.IsVisible = false;
                ReadingRooms1.IsVisible = false;
                ActivityRooms1.IsVisible = false;
                Gym1.IsVisible = false;
                //PointChart
                Chart12.IsVisible = true;
                Chart22.IsVisible = true;
                Chart32.IsVisible = true;
                Chart42.IsVisible = true;
                Chart52.IsVisible = true;
                Chart62.IsVisible = true;
                Chart72.IsVisible = true;
                Chart82.IsVisible = true;
                Chart92.IsVisible = true;
                InFrastructure11.IsVisible = true;
                ClassRooms11.IsVisible = true;
                Library11.IsVisible = true;
                ITLab11.IsVisible = true;
                PCBLabs11.IsVisible = true;
                CommonRooms11.IsVisible = true;
                ReadingRooms11.IsVisible = true;
                ActivityRooms11.IsVisible = true;
                Gym11.IsVisible = true;
                //GaugeRadialChart
                Chart13.IsVisible = false;
                Chart23.IsVisible = false;
                Chart33.IsVisible = false;
                Chart43.IsVisible = false;
                Chart53.IsVisible = false;
                Chart63.IsVisible = false;
                Chart73.IsVisible = false;
                Chart83.IsVisible = false;
                Chart93.IsVisible = false;
                InFrastructure12.IsVisible = false;
                ClassRooms12.IsVisible = false;
                Library12.IsVisible = false;
                ITLab12.IsVisible = false;
                PCBLabs12.IsVisible = false;
                CommonRooms12.IsVisible = false;
                ReadingRooms12.IsVisible = false;
                ActivityRooms12.IsVisible = false;
                Gym12.IsVisible = false;
                //Donut
                Chart14.IsVisible = false;
                Chart24.IsVisible = false;
                Chart34.IsVisible = false;
                Chart44.IsVisible = false;
                Chart54.IsVisible = false;
                Chart64.IsVisible = false;
                Chart74.IsVisible = false;
                Chart84.IsVisible = false;
                Chart94.IsVisible = false;
                InFrastructure13.IsVisible = false;
                ClassRooms13.IsVisible = false;
                Library13.IsVisible = false;
                ITLab13.IsVisible = false;
                PCBLabs13.IsVisible = false;
                CommonRooms13.IsVisible = false;
                ReadingRooms13.IsVisible = false;
                ActivityRooms13.IsVisible = false;
                Gym13.IsVisible = false;
                //RadarChart
               

            }
            if(eg =="RadialGaugeChart")
            {
                //BarChart
                Chart1.IsVisible = false;
                Chart2.IsVisible = false;
                Chart3.IsVisible = false;
                Chart4.IsVisible = false;
                Chart5.IsVisible = false;
                Chart6.IsVisible = false;
                Chart7.IsVisible = false;
                Chart8.IsVisible = false;
                Chart9.IsVisible = false;
                InFrastructure.IsVisible = false;
                ClassRooms.IsVisible = false;
                Library.IsVisible = false;
                ITLab.IsVisible = false;
                PCBLabs.IsVisible = false;
                CommonRooms.IsVisible = false;
                ReadingRooms.IsVisible = false;
                ActivityRooms.IsVisible = false;
                Gym.IsVisible = false;
                //LineChart
                Chart11.IsVisible = false;
                Chart21.IsVisible = false;
                Chart31.IsVisible = false;
                Chart41.IsVisible = false;
                Chart51.IsVisible = false;
                Chart61.IsVisible = false;
                Chart71.IsVisible = false;
                Chart81.IsVisible = false;
                Chart91.IsVisible = false;
                InFrastructure1.IsVisible = false;
                ClassRooms1.IsVisible = false;
                Library1.IsVisible = false;
                ITLab1.IsVisible = false;
                PCBLabs1.IsVisible = false;
                CommonRooms1.IsVisible = false;
                ReadingRooms1.IsVisible = false;
                ActivityRooms1.IsVisible = false;
                Gym1.IsVisible = false;
                //PointChart
                Chart12.IsVisible = false;
                Chart22.IsVisible = false;
                Chart32.IsVisible = false;
                Chart42.IsVisible = false;
                Chart52.IsVisible = false;
                Chart62.IsVisible = false;
                Chart72.IsVisible = false;
                Chart82.IsVisible = false;
                Chart92.IsVisible = false;
                InFrastructure11.IsVisible = false;
                ClassRooms11.IsVisible = false;
                Library11.IsVisible = false;
                ITLab11.IsVisible = false;
                PCBLabs11.IsVisible = false;
                CommonRooms11.IsVisible = false;
                ReadingRooms11.IsVisible = false;
                ActivityRooms11.IsVisible = false;
                Gym11.IsVisible = false;
                //RadialGaugeChart
                Chart13.IsVisible = true;
                Chart23.IsVisible = true;
                Chart33.IsVisible = true;
                Chart43.IsVisible = true;
                Chart53.IsVisible = true;
                Chart63.IsVisible = true;
                Chart73.IsVisible = true;
                Chart83.IsVisible = true;
                Chart93.IsVisible = true;
                InFrastructure12.IsVisible = true;
                ClassRooms12.IsVisible = true;
                Library12.IsVisible = true;
                ITLab12.IsVisible = true;
                PCBLabs12.IsVisible = true;
                CommonRooms12.IsVisible = true;
                ReadingRooms12.IsVisible = true;
                ActivityRooms12.IsVisible = true;
                Gym12.IsVisible = true;
                //DonutChart
                Chart14.IsVisible = false;
                Chart24.IsVisible = false;
                Chart34.IsVisible = false;
                Chart44.IsVisible = false;
                Chart54.IsVisible = false;
                Chart64.IsVisible = false;
                Chart74.IsVisible = false;
                Chart84.IsVisible = false;
                Chart94.IsVisible = false;
                InFrastructure13.IsVisible = false;
                ClassRooms13.IsVisible = false;
                Library13.IsVisible = false;
                ITLab13.IsVisible = false;
                PCBLabs13.IsVisible = false;
                CommonRooms13.IsVisible = false;
                ReadingRooms13.IsVisible = false;
                ActivityRooms13.IsVisible = false;
                Gym13.IsVisible = false;
                //RadarChart
               

            }
            if (eg == "DonutChart")
            {
                //BarChart
                Chart1.IsVisible = false;
                Chart2.IsVisible = false;
                Chart3.IsVisible = false;
                Chart4.IsVisible = false;
                Chart5.IsVisible = false;
                Chart6.IsVisible = false;
                Chart7.IsVisible = false;
                Chart8.IsVisible = false;
                Chart9.IsVisible = false;
                InFrastructure.IsVisible = false;
                ClassRooms.IsVisible = false;
                Library.IsVisible = false;
                ITLab.IsVisible = false;
                PCBLabs.IsVisible = false;
                CommonRooms.IsVisible = false;
                ReadingRooms.IsVisible = false;
                ActivityRooms.IsVisible = false;
                Gym.IsVisible = false;
                //LineChart
                Chart11.IsVisible = false;
                Chart21.IsVisible = false;
                Chart31.IsVisible = false;
                Chart41.IsVisible = false;
                Chart51.IsVisible = false;
                Chart61.IsVisible = false;
                Chart71.IsVisible = false;
                Chart81.IsVisible = false;
                Chart91.IsVisible = false;
                InFrastructure1.IsVisible = false;
                ClassRooms1.IsVisible = false;
                Library1.IsVisible = false;
                ITLab1.IsVisible = false;
                PCBLabs1.IsVisible = false;
                CommonRooms1.IsVisible = false;
                ReadingRooms1.IsVisible = false;
                ActivityRooms1.IsVisible = false;
                Gym1.IsVisible = false;
                //PointChart
                Chart12.IsVisible = false;
                Chart22.IsVisible = false;
                Chart32.IsVisible = false;
                Chart42.IsVisible = false;
                Chart52.IsVisible = false;
                Chart62.IsVisible = false;
                Chart72.IsVisible = false;
                Chart82.IsVisible = false;
                Chart92.IsVisible = false;
                InFrastructure11.IsVisible = false;
                ClassRooms11.IsVisible = false;
                Library11.IsVisible = false;
                ITLab11.IsVisible = false;
                PCBLabs11.IsVisible = false;
                CommonRooms11.IsVisible = false;
                ReadingRooms11.IsVisible = false;
                ActivityRooms11.IsVisible = false;
                Gym11.IsVisible = false;
                //GaugeRadialChart
                Chart13.IsVisible = false;
                Chart23.IsVisible = false;
                Chart33.IsVisible = false;
                Chart43.IsVisible = false;
                Chart53.IsVisible = false;
                Chart63.IsVisible = false;
                Chart73.IsVisible = false;
                Chart83.IsVisible = false;
                Chart93.IsVisible = false;
                InFrastructure12.IsVisible = false;
                ClassRooms12.IsVisible = false;
                Library12.IsVisible = false;
                ITLab12.IsVisible = false;
                PCBLabs12.IsVisible = false;
                CommonRooms12.IsVisible = false;
                ReadingRooms12.IsVisible = false;
                ActivityRooms12.IsVisible = false;
                Gym12.IsVisible = false;
                //DonutChart
                Chart14.IsVisible = true;
                Chart24.IsVisible = true;
                Chart34.IsVisible = true;
                Chart44.IsVisible = true;
                Chart54.IsVisible = true;
                Chart64.IsVisible = true;
                Chart74.IsVisible = true;
                Chart84.IsVisible = true;
                Chart94.IsVisible = true;
                InFrastructure13.IsVisible = true;
                ClassRooms13.IsVisible = true;
                Library13.IsVisible = true;
                ITLab13.IsVisible = true;
                PCBLabs13.IsVisible = true;
                CommonRooms13.IsVisible = true;
                ReadingRooms13.IsVisible = true;
                ActivityRooms13.IsVisible = true;
                Gym13.IsVisible = true;
                //RadarChart
               
            }
            
        }
    }
}