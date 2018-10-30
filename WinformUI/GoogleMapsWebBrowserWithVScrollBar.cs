using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinformUI
{
    public class GoogleMapsWebBrowserWithVScrollBar : GoogleMapsWebBrowserDecorator
    {
        public GoogleMapsWebBrowserWithVScrollBar(GoogleMapsWebBrowser i_GoogleMapsWebBrowser)
            : base(i_GoogleMapsWebBrowser)
        {
        }

        public void Navigate(GeoPoint i_From, GeoPoint i_To)
        {
            m_GoogleMapsWebBrowser.WebBrowser.Controls.Add(new System.Windows.Forms.VScrollBar());
            base.Navigate(i_From, i_To);
        }
    }
}
