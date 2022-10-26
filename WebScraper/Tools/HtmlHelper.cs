namespace WebScraper.Tools
{
    internal class HtmlHelper
    {
        public List<string> ParseHtml(string html)
        {
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(html);

            var programmerLinks = document.DocumentNode.Descendants("li")
                .Where(node => !node.GetAttributeValue("class", "").Contains("tocsection"))
                .ToList();

            List<string> wikiLink = new List<string>();

            foreach(var link in programmerLinks)
            {
                if (link.FirstChild.Attributes.Count > 1)
                        wikiLink.Add(link.FirstChild.Attributes[1].Value);
            }

            return wikiLink;
        }
    }
}
