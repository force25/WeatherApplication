using Newtonsoft.Json;
using ParticularPresence.WeatherApplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ParticularPresence.WeatherApplication.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        public ActionResult KingstonForcast()
        {
            string url = "http://api.openweathermap.org/data/2.5/forecast?id=3489854&appid=89cf0c0f2efddb2dd16edad131d2f949&units=metric";
            var forcast = MakeRequest(url);
            return View(forcast);          
        }

        public ActionResult MontegoBayForcast()
        {
            string url = "http://api.openweathermap.org/data/2.5/forecast?id=3489460&appid=89cf0c0f2efddb2dd16edad131d2f949&units=metric";
            var forcast = MakeRequest(url);
            return View(forcast);
        }

        public List<WeatherData> MakeRequest(string url)
        {
            string requestUrl = url;
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                string html = string.Empty;
                using (response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }
                var info = JsonConvert.DeserializeObject<RootObject>(html);
                var infolist = info.list;

                List<WeatherData> WeatherList = new List<WeatherData>();
                String date = "";

                for (int i = 0; i < infolist.Count; i++)
                {
                    if (date != Convert.ToDateTime(infolist[i].dt_txt).ToShortDateString())
                    {
                        WeatherData weatherdata = new WeatherData();
                        weatherdata.dt_txt = infolist[i].dt_txt;
                        weatherdata.description = infolist[i].weather[0].description;
                        weatherdata.temp = infolist[i].main.temp;
                        weatherdata.humidity = infolist[i].main.humidity;
                        WeatherList.Add(weatherdata);
                        date = Convert.ToDateTime(infolist[i].dt_txt).ToShortDateString();
                    }
                }
                return WeatherList;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}