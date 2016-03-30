using Slugity.Configuration;

namespace Slugity.FormattingTypes
{
    public class TextCaseFormatter : ISlugFormatter
    {
        private ISlugityConfig _configuration;

        public string Format(string transformedString, ISlugityConfig config)
        {
            _configuration = config;

            switch (config.TextCase)
            {
                case TextCase.LowerCase:
                    return transformedString.ToLower();
                case TextCase.CamalCase:
                    return ToCamalCase(transformedString);
                case TextCase.UpperCase:
                    return transformedString.ToUpper();
                default:
                    return transformedString;
            }
        }

        private string ToCamalCase(string input)
        {
            string result = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());

            return result;
        }
    }
}