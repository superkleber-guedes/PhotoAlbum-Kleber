using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace BusinessLayer.Business
{
    public class JsonFromWeb
    {
        public List<T> Get<T>(string url) 
            where T : class
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            String responseContent = String.Empty;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                responseContent = reader.ReadToEnd();
                List<T> result = JsonConvert.DeserializeObject<List<T>>(responseContent);
                return result;
            }
        }
    }
}
