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
            LoadWebViewContent();
        }

        private void LoadWebViewContent()
        {
            var text = EmbeddedResourceHelper.LoadEmbeddedresource(Constants.HomeWebContent);
            Web.Source = new HtmlWebViewSource { Html = text };

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

        void Picker_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MyPickerPage());
        }

        void WebView2_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new WebViewPage("NextPlayGround.next_content_marvinhume2.html"));

        }

        void WebView1_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new WebViewPage("NextPlayGround.marvin_homepage2.html"));

        }
    }
}
