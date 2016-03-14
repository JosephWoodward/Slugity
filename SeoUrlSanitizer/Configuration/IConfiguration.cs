namespace SeoUrlSanitizer.Configuration
{
    public interface IConfiguration
    {
        TextCase TextCase { get; set; }

        char StringSeparator { get; set; }

        int? MaxLength { get; set; }
    }
}