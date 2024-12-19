using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class ButtonField
{
    public ButtonValue Value { get; set; }
}
public class ButtonValue
{
    public string Href { get; set; }
    public string Text { get; set; }
    public string Anchor { get; set; }
    public string LinkType { get; set; }
    public string Class { get; set; }
    public string Title { get; set; }
    public string QueryString { get; set; }
    public string Id { get; set; }
}



public class ImageField
{
    public ImageValue Value { get; set; }
}

public class ImageValue
{
    public string Src { get; set; }
    public string Alt { get; set; }
    public string Width { get; set; }
    public string Height { get; set; }
}

public class SingleLine
{
    public string Value { get; set; }
}

public class CarouselItemField
{
    public ButtonField Button { get; set; } 
    public SingleLine Heading { get; set; } 
    public ImageField Image { get; set; }  
    public SingleLine SubHeading { get; set; } 
}

public class CarouselItem
{
    public string Id { get; set; }
    public string Url { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public CarouselItemField Fields { get; set; }
}

public class HeadingField
{
    public string Value { get; set; }
}