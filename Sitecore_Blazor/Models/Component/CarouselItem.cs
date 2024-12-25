namespace Sitecore_Blazor.Models.Blocks
{
    public class CarouselItem
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public CarouselItemField Fields { get; set; }
    }

    public class CarouselItemField
    {
        public ButtonField Button { get; set; }
        public SingleLine Heading { get; set; }
        public ImageField Image { get; set; }
        public SingleLine SubHeading { get; set; }
    }
}