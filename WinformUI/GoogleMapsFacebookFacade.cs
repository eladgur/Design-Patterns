using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformUI
{
    public static class FacebookMapFacade
    {
        public static void ShowDirections(User i_FromUser, User i_ToUser, WebBrowser i_WebBrowser, bool i_ShowHScrollBar, bool i_ShowVScrollBar)
        {
            GoogleMapsWebBrowser googleMapsWebBrowser = new GoogleMapsWebBrowser(i_WebBrowser);

            if (i_ShowHScrollBar)
            {
                googleMapsWebBrowser = new GoogleMapsWebBrowserWithHScrollBar(googleMapsWebBrowser);
            }

            if (i_ShowVScrollBar)
            {
                googleMapsWebBrowser = new GoogleMapsWebBrowserWithVScrollBar(googleMapsWebBrowser);
            }

            try
            {
                GeoPoint fromPoint = parse(i_FromUser);
                GeoPoint toPoint = parse(i_ToUser);
                googleMapsWebBrowser.Navigate(fromPoint, toPoint);
            }
            catch (Exception)
            {
                // We will get here because not permitions from Facebook =]
            }
        }

        private static GeoPoint parse(User i_User)
        {
            double longitude = i_User.Location.Location.Longitude.Value;
            double latitude = i_User.Location.Location.Latitude.Value;
            GeoPoint point = new GeoPoint() { Longitude = longitude, Latitude = latitude };

            return point;
        }
    }
}
