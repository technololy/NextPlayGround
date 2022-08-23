using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NextPlayGround
{
    public partial class Carousel : ContentPage
    {
        public List<CarouselData> CarouselDataObject { get; set; }
        public Carousel()
        {
            InitializeComponent();
            CarouselDataObject = new List<CarouselData>()
            {
                new CarouselData{Name="1",Image="image1",Color="Red"},
                new CarouselData{Name="2",Image="image2",Color="Green"},
                new CarouselData{Name="3",Image="image3",Color="Yellow"},
            };
            BindingContext = this;

        }




        public class CarouselData
        {
            public string Name { get; set; }
            public string Image { get; set; }
            public string Color { get; set; }
        }
    }
}
