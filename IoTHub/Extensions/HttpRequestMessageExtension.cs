using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IoT.Service.Extensions
{
 public static   class HttpRequestMessageExtension
    {
        private const string HttpContext = "MS_HttpContext";
        public static string GetRemoteClientIpAddress(this HttpRequestMessage request)
        {
            if (request.Properties.ContainsKey(HttpContext))
            {
                dynamic ctx = request.Properties[HttpContext];
                if (ctx != null)
                {
                    return ctx.Request.UserHostAddress;
                }              
            }

            return null;
        }
    }
}
