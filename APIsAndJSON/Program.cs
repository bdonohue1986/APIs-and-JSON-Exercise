using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            var convo = new Kanye();

            for (int i = 1; i < 11; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($" Kanye : {convo.YE()}");
                }
                else { Console.WriteLine($"Ron: { convo.Ron()}");}
            }

            var tempNY = new OpenWeatherMapAPI();

            Console.WriteLine($"The temp in New York is {tempNY.CurrentTemp()}");

        }
    }
}
