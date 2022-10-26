namespace WebScraper.Tools
{
    internal class Exporter
    {
        public void WriteToCSV(List<string> items)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Begin");
            foreach (var item in items)
            {
                builder.AppendLine(item);
            }
            builder.AppendLine("End");

            File.WriteAllText("M:\\Documents\\Coding\\C#\\projects\\WebScraper\\output\\ScrapedItems.csv", builder.ToString());
        }
    }
}
