using IoT.Service.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IoT.Service.Controllers
{
    public class IoTController : ApiController
    {
        // GET: api/IoT
        public string Get()
        {  
           return Request.GetRemoteClientIpAddress();
        }


 
    }
}
