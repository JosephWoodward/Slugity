using Slugity.Configuration;

namespace Slugity.FormattingTypes
{
    public class TextCaseFormatter : ISlugFormatter
    {
        public string Format(string transformedString, ISlugityConfig config)
        {
            switch (config.TextCase)
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