using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public class SeparatorFormatter : ISlugFormatter
    {
        public string Format(string transformedString, IConfiguration configuration)
        {
            return transformedString;
        }
    }
}