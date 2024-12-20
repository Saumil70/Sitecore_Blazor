using Sitecore_Blazor.Models.Blocks;

namespace Sitecore_Blazor.Models.Shared
{
    public class FooterModel
    {
        public SingleLine CopyrightText { get; set; } 
        public SingleLine SitemapText { get; set; }
        public ButtonField CopyrightDescription { get; set; }
        public ButtonField SiteText { get; set; }
        public SingleLine SocialText { get; set; }
        public List<SocialLinkModel> SocialLinks { get; set; }
        public List<SiteMapLinkModel> SiteMapLinks { get; set; }

    }
}
