using System.Text;
using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public class SeparatorFormatter : ISlugFormatter
    {
        public string Format(string input, StringBuilder finalString, IConfiguration configuration)
        {
            return input;
        }
    }
}