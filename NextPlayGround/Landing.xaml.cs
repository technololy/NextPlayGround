using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NextPlayGround
{
    public partial class Landing : ContentPage
    {
        public Landing()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Carousel());
        }

        void Button2_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

        }

        void VSM_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new VSMSamples());
        }
    }
}
