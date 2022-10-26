// See https://aka.ms/new-console-template for more information
using WebScraper.Tools;

Console.WriteLine("Hello, World!");
HttpHelper httpHelper = new HttpHelper();
HtmlHelper htmlHelper = new HtmlHelper();

var html = httpHelper.IndexHtml();
var list = htmlHelper.ParseHtml(html);

foreach(var item in list)
{
    Console.WriteLine(item);
}

