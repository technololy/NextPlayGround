using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace NextPlayGround
{
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage(string filename = "")
        {
            InitializeComponent();
            //Web.Source = new HtmlWebViewSource { Html = Properties.Resources.HtmlFile };
            //"NextPlayGround.marvin_homepage2.html"
            LoadEmbeddedresource(filename);
        }

        private void LoadEmbeddedresource(string fileName)
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(WebViewPage)).Assembly;
            Stream stream = assembly.GetManifestResourceStream(fileName);
            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            Web.Source = new HtmlWebViewSource { Html = text };

        }
    }
}
