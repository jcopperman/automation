using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutomationAssessment
{
    public class HttpUtils
    {
        public void GetAllBreeds(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://dog.ceo/api/breeds/list/all");
            request.Method = "Post";
            request.KeepAlive = true;
            request.ContentType = "application/json";
            request.Headers.Add("Content-Type", "appication/json");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string myResponse = "";
            using (System.IO.StreamReader sr = new System.IO.StreamReader(response.GetResponseStream()))
            {
                myResponse = sr.ReadToEnd();
            }
           
        }

        public void GetSubBreedsOfBreed()
        {

        }

        public void GetQueriedSubBreed()
        {

        }
    }
}
