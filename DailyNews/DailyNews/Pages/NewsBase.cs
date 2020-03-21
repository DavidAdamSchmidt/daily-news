using DailyNews.Models;
using DailyNews.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace DailyNews.Pages
{
    public class NewsBase : ComponentBase
    {
        public NewsData NewsData { get; set; }

        public string SearchTerm { get; set; } = string.Empty;

        public bool IsUpdateDisabled => SearchTerm.Length == 0;

        [Inject]
        private NewsService NewsService { get; set; }

        public async Task UpdateNews()
        {
            NewsData = await NewsService.GetNewsAsync(SearchTerm);
        }
    }
}
