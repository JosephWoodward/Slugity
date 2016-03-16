using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public class MaxLengthFormatter : ISlugFormatter
    {
        public string Format(string transformedString, IConfiguration configuration)
        {
            // If slug is shorter than MaxLength
            if (configuration.MaxLength == null || transformedString.Length <= configuration.MaxLength)
                return transformedString;

            // If MaxLength ends on separator, remove separator
            int charPos = configuration.MaxLength.Value - 1;
            char charAtPos = transformedString[charPos];
            if (charAtPos == configuration.StringSeparator)
                return transformedString.Substring(0, charPos);

            // If MaxLength ends on word, ensure it doesn't get truncated
            int length = transformedString.Length;
            int realMaxLength = configuration.MaxLength.Value;
            for (int i = 0; i < length; i++)
            {
                char c = transformedString[i];
                if (i <= realMaxLength || c != configuration.StringSeparator) continue;

                realMaxLength = i;
                break;
            }

            string result = transformedString.Substring(0, realMaxLength);
            return result;
        }
    }
}