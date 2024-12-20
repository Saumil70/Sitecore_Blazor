namespace Sitecore_Blazor.Models.Shared
{
    public class NavigationItem
    {
        public string Id { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public NavigationItemField Fields { get; set; } = new NavigationItemField();
    }

    public class NavigationItemField
    {
        public SingleLine ShowInNavigation { get; set; } = new SingleLine();
        public SingleLine pageTitle { get; set; } = new SingleLine();
    }
}
