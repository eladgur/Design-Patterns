using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinformUI
{
    public abstract class GoogleMapsWebBrowserDecorator : GoogleMapsWebBrowser
    {
        protected GoogleMapsWebBrowser m_GoogleMapsWebBrowser;

        public GoogleMapsWebBrowserDecorator(GoogleMapsWebBrowser i_GoogleMapsWebBrowser)
            : base(i_GoogleMapsWebBrowser.WebBrowser)
        {
            this.m_GoogleMapsWebBrowser = i_GoogleMapsWebBrowser;
        }

        public void Navigate(GeoPoint i_From, GeoPoint i_To)
        {
            m_GoogleMapsWebBrowser.Navigate(i_From, i_To);
        }
    }
}
