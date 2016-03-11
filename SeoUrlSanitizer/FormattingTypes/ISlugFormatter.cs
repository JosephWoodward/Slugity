using System.Text;
using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public interface ISlugFormatter
    {
        string Format(string input, StringBuilder finalString, IConfiguration configuration);
    }
}