using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public class StopWordFormatter : ISlugFormatter
    {
        public string Format(string transformedString, IConfiguration configuration)
        {
            return transformedString;
        }
    }
}