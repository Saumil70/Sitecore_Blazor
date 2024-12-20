namespace Sitecore_Blazor.Models.Shared
{
    public class SiteMapLinkModel
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public SiteMapLinkField Fields { get; set; }
    }

    public class SiteMapLinkField
    {
        public ButtonField Link { get; set; }
    }
}
