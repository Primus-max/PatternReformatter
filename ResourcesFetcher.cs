using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace PatternReformatter
{
    public class ResourcesFetcher
    {
        private const string ResourcesUrl = "https://gist.githubusercontent.com/SmsactivatorRu/425c14718f975bd8bd25d90aa421cee7/raw/gistfile1.txt";
        private const string LocalFilePath = "resources.txt";

        public async Task<(string bannerImageUrl, string redirectUrl)> FetchResources()
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    string resources = await httpClient.GetStringAsync(ResourcesUrl);
                    if (!string.IsNullOrEmpty(resources))
                    {
                        File.WriteAllText(LocalFilePath, resources);
                        string[] lines = resources.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                        if (lines.Length >= 2)
                        {
                            return (lines[0], lines[1]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching resources: {ex.Message}");
            }

            return (null, null);
        }
    }
}
