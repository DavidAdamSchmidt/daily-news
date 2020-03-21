using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace DailyNews.Shared
{
    public partial class SearchBox
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        public string SearchTerm { get; set; }

        public void HandleKeyPress(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                NavigationManager.NavigateTo($"/search/{SearchTerm}");
            }
        }
    }
}
