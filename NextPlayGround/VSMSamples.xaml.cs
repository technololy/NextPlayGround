using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NextPlayGround
{
    public partial class VSMSamples : ContentPage
    {
        public VSMSamples()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            var tapped = ((TappedEventArgs)e).Parameter.ToString();
            if (tapped=="one")
            {
                VisualStateManager.GoToState(lblOne, "Selected");
                VisualStateManager.GoToState(lblTwo, "Normal");
            }
            else if(tapped=="two")
            {
                VisualStateManager.GoToState(lblTwo, "Selected");
                VisualStateManager.GoToState(lblOne, "Normal");

            }
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            VisualStateManager.GoToState(btnGolang, "Clicked");
            VisualStateManager.GoToState(btnDotNet, "Normal");
        }

        void btnDotNet_Clicked(System.Object sender, System.EventArgs e)
        {
            VisualStateManager.GoToState(btnDotNet , "Clicked");
            VisualStateManager.GoToState(btnGolang, "Normal");
        }
    }
}
