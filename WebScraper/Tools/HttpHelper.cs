namespace WebScraper.Tools
{
    internal class HttpHelper
    {
        private static string fullUrl;

        private static string FullUrl
        {
            get { return fullUrl; }
            set { fullUrl = value; }
        }

        public HttpHelper(string fullUrl)
        {
            FullUrl = fullUrl;
        }
        private static async Task<string> CallUrl()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(FullUrl);
            return response;
        }

        public string IndexHtml()
        {
            var response = CallUrl().Result;
            return response;
        }
    }
}
