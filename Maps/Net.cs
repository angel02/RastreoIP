using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Maps
{
    public class Net
    {
        public static string[] HttpRequest(string url)
        {

            HttpWebRequest Request;
            HttpWebResponse Response;
            string responseRead = "";

            try
            {
                Request = (HttpWebRequest)WebRequest.Create(url);
                Response = (HttpWebResponse)Request.GetResponse();

                Request.Timeout = 100000;

                StreamReader responseStream = null;
                


                responseStream = new StreamReader(Response.GetResponseStream());
                responseRead = responseStream.ReadToEnd();

                responseStream.Close();
                responseStream.Dispose();

                return responseRead.Split('\n');
            }
            catch (Exception ex)
            {
               
            }
            return null;

        }
    }
}
