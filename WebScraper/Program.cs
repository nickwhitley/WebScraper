// See https://aka.ms/new-console-template for more information
using WebScraper.Tools;

Console.WriteLine("Please input the full url to the page you would like to scrape: \n");
var userInput = Console.ReadLine();

while(userInput is null or "")
{
    Console.WriteLine("Please input the full url to the page you would like to scrape: \n");
    userInput = Console.ReadLine();
}

HttpHelper httpHelper = new HttpHelper(userInput);
HtmlHelper htmlHelper = new HtmlHelper();
Exporter exporter = new Exporter();

var html = httpHelper.IndexHtml();
var list = htmlHelper.ParseHtml(html);

try
{
    exporter.WriteToCSV(list);
}
catch (Exception e)
{
    Console.WriteLine("Failed to write to csv.");
    Console.WriteLine(e.Message);
}

foreach (var item in list)
{
    Console.WriteLine(item);
}



