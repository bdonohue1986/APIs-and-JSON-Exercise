using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class Kanye
    {

        HttpClient client = new HttpClient();


        public string YE()
        {
            var KanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(KanyeURL).Result;
            var KanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            return KanyeQuote;
        }
        public string Ron()
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var RonResponse = client.GetStringAsync(ronURL).Result;
            var RonQuote = JArray.Parse(RonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            return RonQuote.ToString();

        }
    }
}
