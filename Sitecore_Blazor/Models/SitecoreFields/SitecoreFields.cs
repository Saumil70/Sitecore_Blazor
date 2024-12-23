using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Sitecore_Blazor;
using Sitecore_Blazor.Models.SitecoreFields;

public class ButtonField
{
    public ButtonValue Value { get; set; }
}
public class ButtonValue
{
    private string _href;

    public string Href
    {
        get => _href;
        set
        {
            if (!string.IsNullOrEmpty(value) && value.Contains(Constants.UrlWithVersion))
            {
                _href = value.Split('/').Last().ToLower();
                if(_href == "")
                {
                    _href = _href + "/home";
                }
            }
            else
            {
                _href = value;
            }
        }
    }
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
    private string _src;

    public string Src
    {
        get => string.IsNullOrEmpty(_src) ? string.Empty : ImageResolver.ResolveUrl(_src);
        set => _src = value;
    }
    public string Alt { get; set; }
    public string Width { get; set; }
    public string Height { get; set; }
}

public class SingleLine
{
    public string Value { get; set; }
}

public class HeadingField
{
    public string Value { get; set; }
}