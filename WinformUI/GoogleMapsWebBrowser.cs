using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformUI
{
    public class GoogleMapsWebBrowser
    {
        private const string k_GoogleMapsUrl = "https://www.google.com/maps/dir";
        public WebBrowser WebBrowser { get; private set; }

        public GoogleMapsWebBrowser(WebBrowser i_WebBrowser)
        {
            this.WebBrowser = i_WebBrowser;
        }

        public void Navigate(GeoPoint i_From, GeoPoint i_To)
        {
            string url = string.Format("{0}/{1},{2}/{3},{4}", k_GoogleMapsUrl, i_From.Latitude, i_From.Longitude, i_To.Latitude, i_To.Longitude);
            WebBrowser.Navigate(url);
        }
    }
}
