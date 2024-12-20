namespace Sitecore_Blazor.Models.SitecoreFields
{
    public static class ImageResolver
    {
        public static string ResolveUrl(string src)
        {
            if (string.IsNullOrEmpty(src)) return string.Empty;
            if (src.StartsWith("http", StringComparison.OrdinalIgnoreCase)) return src;
            return $"{Constants.SitecoreCMUrl}{src}";
        }
    }
}
