using DailyNews.Models;
using DailyNews.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace DailyNews.Pages
{
    public partial class Search
    {
        private string _previousSearchTerm;

        public NewsData NewsData { get; set; }

        public string SearchTerm { get; set; } = string.Empty;

        public bool IsUpdateDisabled => SearchTerm.Length == 0;

        public bool IsLoading { get; set; }

        [Inject]
        private NewsService NewsService { get; set; }

        public async Task UpdateNews()
        {
            if (SearchTerm == _previousSearchTerm)
            {
                return;
            }

            IsLoading = true;
            _previousSearchTerm = SearchTerm;

            NewsData = await NewsService.GetNewsAsync(SearchTerm);

            IsLoading = false;
        }
    }
}
