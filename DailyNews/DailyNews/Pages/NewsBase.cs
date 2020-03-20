using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace DailyNews.Pages
{
    public class NewsBase : ComponentBase
    {
        public List<string> NewsList { get; } = new List<string>();

        public string SearchTerm { get; set; } = string.Empty;

        public bool IsUpdateDisabled => SearchTerm.Length == 0;

        public void UpdateNews()
        {
            NewsList.Add(SearchTerm);
        }
    }
}
