namespace Sitecore_Blazor
{
    public static class Constants
    {
        // Content api url to get items : "https://svblazor104sc.dev.local/sitecore/api/layout/render/jss?item=/sitecore/content/sitecore-jss-app/home&sc_apikey={FEBD335E-33C9-450A-A3E3-43ED98731FBA}"
        // Content api url to get dictionary : "https://svblazor104sc.dev.local/sitecore/api/jss/dictionary/sitecore-jss-app/en?sc_apikey={FEBD335E-33C9-450A-A3E3-43ED98731FBA}

        public const string SitecoreCMUrl = "https://svblazor104sc.dev.local";
        public const string LayoutRender = "/sitecore/api/layout/render/jss";
        public const string DictionaryRender = "/sitecore/api/jss/dictionary/";
        public const string ItemApi = "?item=";
        public const string ProjectRoot = "/sitecore/content/sitecore-jss-app/";
        public const string SCApiKey = "{FEBD335E-33C9-450A-A3E3-43ED98731FBA}";

        public const string GetContentByUrlEndpoint = "/api/ContentApi/GetByUrl?path=";
        public const string GetHeaderEndpoint = "/api/HeaderViewComponent/GetHeaderData";
        public const string GetFooterEndpoint = "/api/FooterViewComponent/GetFooterData";
        public const string UrlWithVersion = "svblazor104sc.dev.local/en/";
        public const string AppNameWithVersion = "sitecore-jss-app/en";
    }
}
