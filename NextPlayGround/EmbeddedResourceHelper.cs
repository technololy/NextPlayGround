using System;
using System.IO;
using System.Reflection;

namespace NextPlayGround
{
    public class EmbeddedResourceHelper
    {
        public EmbeddedResourceHelper()
        {
        }


        public static string LoadEmbeddedresource(string fileName)
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(WebViewPage)).Assembly;
            Stream stream = assembly.GetManifestResourceStream(fileName);
            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            return text;

        }
    }
}
