using Newtonsoft.Json;

namespace Sitecore_Blazor.Helper
{
    public static class FieldHelper
    {
        // Generic method to serialize and deserialize an object
        public static T MapModel<T>(Dictionary<string, object> obj)
        {
            // Serialize the object to a JSON string
            var json = JsonConvert.SerializeObject(obj);

            // Deserialize the JSON string back into the specified type
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
