using System.Net;

namespace GamersGateScraperLibrary
{
    public class PriceFetcher
    {
        public static Price GetPrice(string url)
        {
            var stringContent = StringContent(url);
            var parsed = stringContent.Replace("&nbsp;", string.Empty).Replace("&euro;", string.Empty);
            var currency = double.Parse(parsed);
            return new Price
            {
                Value = currency
            };
        }

        private static string StringContent(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (var objStream = request.GetResponse().GetResponseStream())
            {
                HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.Load(objStream);
                var result = htmlDoc.DocumentNode.SelectSingleNode("//div[@class=\"price_price\"]/span");
                return result.InnerText;
            }
        }
    }
}
