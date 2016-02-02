using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FHR_Data_Access
{
    public class ServiceProxy
    {
        private string url;
        private const string locationKey = "fhrsid";

        public ServiceProxy(string url)
        {
            this.url = url;
        }

        public string GetAllLocations()
        {
            return GET(this.url);        
        }

        public string GetSingleLocation(string locationId)
        {
            var request = string.Format("{0}?{1}={2}", this.url, locationKey, locationId);
            return GET(request);
        }

        private string GET(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    //Implement logging
                }
                throw;
            }
        }
    }
}
