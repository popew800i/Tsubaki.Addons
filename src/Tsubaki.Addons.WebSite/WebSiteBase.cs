using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite
{
    class WebSiteBase : IWebSite
    {
        string IWebSite.Facebook()
        {
            var result = "fb.me";
            return result;
        }

        string IWebSite.Google()
        {
            var result = "www.google.com";
            return result;
        }

        string IWebSite.Youtube()
        {
            var result = "www.youtube.com";
            return result;
        }
    }
}
