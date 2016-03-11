using System.Text;
using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public class TextCaseFormatter : ISlugFormatter
    {
        public string Format(string input, StringBuilder finalString, IConfiguration configuration)
        {
            switch (configuration.TextCase)
            {
                case TextCase.LowerCase:
                    return input.ToLower();
                case TextCase.UpperCase:
                    return input.ToUpper();
                default:
                    return input;
            }
        }
    }
}