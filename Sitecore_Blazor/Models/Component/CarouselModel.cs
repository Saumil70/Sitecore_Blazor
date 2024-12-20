using System.ComponentModel.DataAnnotations;


namespace Sitecore_Blazor.Models.Blocks
{
    public class CarouselModel
    {
        public HeadingField Heading { get; set; }
        public List<CarouselItem> CarouselList { get; set; }
    }
}