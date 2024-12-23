namespace Sitecore_Blazor
{
    public static class Constants
    {
        public const string SitecoreCMUrl = "https://sc104blazorsc.dev.local";
        public const string LayoutRender = "/sitecore/api/layout/render/jss";
        public const string DictionaryRender = "/sitecore/api/jss/dictionary/";
        public const string ItemApi = "?item=";
        public const string ProjectRoot = "/sitecore/content/sitecore-jss-app/";
        public const string SCApiKey = "{C2B5071F-9C42-43FA-B713-D4C6BC520955}";

        public const string GetContentByUrlEndpoint = "/api/ContentApi/GetByUrl?path=";
        public const string GetHeaderEndpoint = "/api/HeaderViewComponent/GetHeaderData";
        public const string GetFooterEndpoint = "/api/FooterViewComponent/GetFooterData";
        public const string UrlWithVersion = "sc104blazorsc.dev.local/en/";
        public const string AppNameWithVersion = "sitecore-jss-app/en";
    }
}
