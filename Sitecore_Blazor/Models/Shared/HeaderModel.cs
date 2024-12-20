using Sitecore_Blazor.Models.Blocks;

namespace Sitecore_Blazor.Models.Shared
{
    public class HeaderModel
    {
        public List<NavigationItem> items { get; set; }
        public string CurrentPage { get; set; }
    }
}
