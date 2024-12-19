using System.ComponentModel.DataAnnotations;


namespace Sitecore_Blazor.Models.Blocks
{
    public class CarouselItemModel
    {
        public virtual string Image { get; set; }
        public virtual string ImageDescription { get; set; }
        public virtual string Heading { get; set; }
        public virtual string SubHeading { get; set; }
        public virtual string ButtonText { get; set; }
        public virtual string ButtonLink { get; set; }
    }
}