using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace WebResponseTest35
{
    class Program
    {
        static void Main(string[] args)
        {
            //AllowAllCertificate();
            while (true)
            {
                Console.ReadLine();
                //var response = Get("https://192.168.0.11:8089/servicesNS/-/search/configs/conf-savedsearches?count=-1");
                var response = Get("https://www.google.com");
                using (var reader = new StreamReader(response.Content))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
        }

        static ResponseMessage Get(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            //request.Headers.Add("Authorization", "Splunk 5bb6cb5d64d1947c4c69375931f87142");
            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();
            return new ResponseMessage(responseStream, response);
        }

        static void AllowAllCertificate()
        {
            if (ServicePointManager.ServerCertificateValidationCallback == null)
            {
                ServicePointManager.ServerCertificateValidationCallback =
                    (sender, certificate, chain, sslPolicyErrors) => true;
            }

        }
    }
}
