using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        HttpClient client = new HttpClient();

        public string CurrentTemp()
        {
            
            const string API_KEY = "dd7b492f9a3ad2b2f2bea11aba7daba8";
            var weatherAPI = $"https://api.openweathermap.org/data/2.5/weather?lat=40.7128&lon=-74.0060&appid={API_KEY}&units=imperial";
            var weatherResponse = client.GetStringAsync(weatherAPI).Result;
            var tempresponse = JObject.Parse(weatherResponse).GetValue("main")["temp"] ;
            return tempresponse.ToString() + "°F";

        }
    }
}
