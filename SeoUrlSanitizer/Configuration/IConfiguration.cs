namespace SeoUrlSanitizer.Configuration
{
    public interface IConfiguration
    {
        TextCase TextCase { get; set; }

        string Separator { get; set; }
    }
}