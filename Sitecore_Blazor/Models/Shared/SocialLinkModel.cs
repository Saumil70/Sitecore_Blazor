namespace Sitecore_Blazor.Models.Shared
{
    public class SocialLinkModel
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public SocialLinkField Fields { get; set; }
    }

    public class SocialLinkField
    {
        public ButtonField Link { get; set; }
    }
}
