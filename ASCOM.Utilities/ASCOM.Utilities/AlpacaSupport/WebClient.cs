

using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;

namespace ASCOM.Utilities
{

    internal class WebClientWithTimeOut

        
    {

        public  int Timeout { get; set; }

        protected  WebRequest GetWebRequest(Uri uri)
        {

            WebRequest client = GetWebRequest(uri);
            client.Timeout = Timeout;
 
            return client;
        }
    }
}