namespace SeoUrlSanitizer.Configuration
{
    public interface IConfiguration
    {
        TextCase TextCase { get; set; }

        string StringSeparator { get; set; }
    }
}