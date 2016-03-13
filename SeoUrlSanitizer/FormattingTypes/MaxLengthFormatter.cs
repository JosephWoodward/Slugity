using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public class MaxLengthFormatter : ISlugFormatter
    {
        public string Format(string transformedString, IConfiguration configuration)
        {
            if (configuration.MaxLength == null) return transformedString;

            return transformedString.Length > configuration.MaxLength
                ? transformedString.Substring(0, configuration.MaxLength.Value)
                : transformedString;
        }
    }
}