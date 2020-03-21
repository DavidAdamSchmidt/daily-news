using DailyNews.Models;
using DailyNews.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace DailyNews.Pages
{
    public partial class Search
    {
        private string _previousSearchTerm;

        [Parameter]
        public string SearchTerm { get; set; }

        [Inject]
        private NewsService NewsService { get; set; }

        public NewsData NewsData { get; set; }

        public bool IsLoading { get; set; }

        protected override Task OnParametersSetAsync()
        {
            return UpdateNews();

        }

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
