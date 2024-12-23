namespace Sitecore_Blazor.Helper
{
    public class DictionaryHelper
    {
        private static Dictionary<string, string> _dictionaryData = new Dictionary<string, string>();

        public static void SetDictionaryData(Dictionary<string, string> dictionaryData)
        {
            _dictionaryData = dictionaryData;
        }

        public static string GetValue(string key)
        {
            return _dictionaryData.ContainsKey(key) ? _dictionaryData[key] : key;
        }
    }
}
