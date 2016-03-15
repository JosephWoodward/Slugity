using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public class TextCaseFormatter : ISlugFormatter
    {
        public string Format(string transformedString, IConfiguration configuration)
        {
            switch (configuration.TextCase)
            {
                case TextCase.LowerCase:
                    return transformedString.ToLower();
                case TextCase.UpperCase:
                    return transformedString.ToUpper();
                default:
                    return transformedString;
            }
        }
    }
}