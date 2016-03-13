using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public interface ISlugFormatter
    {
        string Format(string transformedString, IConfiguration configuration);
    }
}