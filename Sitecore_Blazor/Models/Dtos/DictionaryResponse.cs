namespace Sitecore_Blazor.Models.Dtos
{
    public class DictionaryResponse
    {
        public string Lang { get; set; }
        public string App { get; set; }
        public Dictionary<string, string> Phrases { get; set; }
    }
}
