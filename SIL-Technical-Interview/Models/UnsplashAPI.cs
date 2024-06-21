public class UnsplashAPI
{
    public string? Id { get; set; }
    public string? Slug { get; set; }
    public URLS? Urls { get; set; }
    public string? Description { get; set; }
    public string? AltDescription { get; set; }
    public string? Raw { get; set; }
    public string? Full { get; set; }
    public string? Regular { get; set; }
    public string? Small { get; set; }
    public string? Thumb { get; set; }
    public string? SmallS3 { get; set; }
}

//URLS class
public class URLS
{
    public string? Raw { get; set; }
    public string? Full { get; set; }
    public string? Regular { get; set; }
    public string? Small { get; set; }
    public string? Thumb { get; set; }
    public string? SmallS3 { get; set; }
}