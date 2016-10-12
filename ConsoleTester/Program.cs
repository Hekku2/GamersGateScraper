using System;
using GamersGateScraperLibrary;

namespace ConsoleTester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var testUrls = new[] 
            {
                "http://www.gamersgate.com/DD-ARAGAMI/aragami",
                "http://www.gamersgate.com/DD-FEAR2/fear-2-project-origin",
                "http://www.gamersgate.com/DD-GC3/galactic-civilizations-iii"
            };
            
            foreach (var testUrl in testUrls)
            {
                var result = PriceFetcher.GetPrice(testUrl);
                Console.WriteLine(result.Value);
            }
            Console.ReadLine();
        }
    }
}
