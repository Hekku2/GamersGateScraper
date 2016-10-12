# GamersGateScraper
DLL that scrapes price data from http://www.gamersgate.com/

NOTE: Done for personal use, so no guarantees that this works in future or unexpected situations.

## Usage

### PriceFetcher
GetPrice - Retrieves price information from given page. If page is not found or something goes wrong, some exception is thrown.

```
var result = PriceFetcher.GetPrice("http://www.gamersgate.com/DD-GC3/galactic-civilizations-iii");
Console.WriteLine(result.Value);
```

## Libraries used
[HtmlAgilityPack 1.4.9.5](http://htmlagilitypack.codeplex.com/)

## License
MIT