using DailyNews.Models;
using Microsoft.AspNetCore.Components;

namespace DailyNews.Shared
{
    public partial class News
    {
        [Parameter]
        public Article Article { get; set; }
    }
}
