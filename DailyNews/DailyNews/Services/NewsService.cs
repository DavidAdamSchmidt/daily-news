using DailyNews.Models;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DailyNews.Services
{
    public class NewsService
    {
        private readonly IOptions<AppSecrets> _secrets;

        public NewsService(IOptions<AppSecrets> secrets)
        {
            _secrets = secrets;
        }

        public async Task<NewsData> GetNewsAsync(string searchTerm, int page)
        {
            var url = $"http://newsapi.org/v2/everything?q={searchTerm}&page={page}&apiKey={_secrets.Value.NewsApiKey}";

            var jsonString = await new HttpClient().GetStringAsync(url);

            return JsonSerializer.Deserialize<NewsData>(jsonString);
        }
    }
}
