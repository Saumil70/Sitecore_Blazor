namespace Sitecore_Blazor.Models.Component
{

    public class Product
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public ProductField Fields { get; set; }
    }

    public class ProductField
    {
        public SingleLine Price { get; set; }
        public ImageField Image { get; set; }
        public SingleLine ProductDescription { get; set; }
        public SingleLine ProductName { get; set; }
        public SingleLine ProductStatus { get; set; }
    }

}
