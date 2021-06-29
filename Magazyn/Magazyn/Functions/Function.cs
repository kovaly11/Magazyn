using Magazyn.Tables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn.Functions
{
   public class Function
    {
        public string LogIn(string login, string password)
        {
            WebRequest request = WebRequest.Create("http://localhost:8090/prac/log?login="+
                login + "&passw=" + password);
            WebResponse response = request.GetResponse();
            StreamReader stream = new StreamReader(response.GetResponseStream());
            return stream.ReadLine();
        }

        public List<T> ToList<T>(string path)
        {
            WebRequest request = WebRequest.Create(path);
            WebResponse response = request.GetResponse();
            StreamReader stream = new StreamReader(response.GetResponseStream());
            return JsonConvert.DeserializeObject<List<T>>(stream.ReadLine());
        }

        public T ToEntity<T>(string path)
        {
            WebRequest request = WebRequest.Create(path);
            WebResponse response = request.GetResponse();
            StreamReader stream = new StreamReader(response.GetResponseStream());
            return JsonConvert.DeserializeObject<T>(stream.ReadLine());
        }

        public string PostReq(string path, string postData)
        {
            var request = (HttpWebRequest)WebRequest.Create(path);
            
            
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
    }
}
