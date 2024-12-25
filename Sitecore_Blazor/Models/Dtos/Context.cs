namespace sitecoreblazor.SitecoreModels
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Context
    {
        public long visitorIdentificationTimestamp { get; set; }
        public bool pageEditing { get; set; }
        public Site site { get; set; }
        public string pageState { get; set; }
        public string language { get; set; }
        public string itemPath { get; set; }
    }

    public class Fields
    {
        public PageTitle pageTitle { get; set; }
        public Title title { get; set; }
        public Subtitle subtitle { get; set; }
    }

    public class Component
    {
        public string uid { get; set; }
        public string componentName { get; set; }
        public string dataSource { get; set; }
        public Params @params { get; set; }
        public Dictionary<string, object> fields { get; set; }
    }

    public class PageTitle
    {
        public string value { get; set; }
    }

    public class Params
    {
    }

    /*    public class Placeholder
        {
            [JsonExtensionData]
            public Dictionary<string, List<Component>> Components { get; set; }
        }*/

    public class Root
    {
        public Sitecore sitecore { get; set; }
    }

    public class Route
    {
        public string name { get; set; }
        public string displayName { get; set; }
        public Fields fields { get; set; }
        public string databaseName { get; set; }
        public string deviceId { get; set; }
        public string itemId { get; set; }
        public string itemLanguage { get; set; }
        public int itemVersion { get; set; }
        public string layoutId { get; set; }
        public string templateId { get; set; }
        public string templateName { get; set; }
        public Dictionary<string, List<Component>> placeholders { get; set; }
    }

    public class Site
    {
        public string name { get; set; }
    }

    public class Sitecore
    {
        public Context context { get; set; }
        public Route route { get; set; }
    }

    public class Subtitle
    {
        public string value { get; set; }
    }

    public class Title
    {
        public string value { get; set; }
    }


}
