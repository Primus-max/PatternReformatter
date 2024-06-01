using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace PatternReformatter
{
    public class ResourcesFetcher
    {
        private const string ResourcesUrl = "https://gist.githubusercontent.com/Primus-max/65db35ac4fe7a43ac38381179dc54b32/raw/ee0626116ac1e682c59d1523e5e598dda239bb4f/resources.txt";
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
