// See https://aka.ms/new-console-template for more information
using WebScraper.Tools;

Console.WriteLine("Hello, World!");
HttpHelper httpHelper = new HttpHelper();
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



