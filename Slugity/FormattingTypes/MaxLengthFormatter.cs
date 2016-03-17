using Slugity.Configuration;

namespace Slugity.FormattingTypes
{
    public class MaxLengthFormatter : ISlugFormatter
    {
        public string Format(string transformedString, ISlugityConfig config)
        {
            // If slug is shorter than MaxLength
            if (config.MaxLength == null || transformedString.Length <= config.MaxLength)
                return transformedString;

            // If MaxLength ends on separator, remove separator
            int charPos = config.MaxLength.Value - 1;
            char charAtPos = transformedString[charPos];
            if (charAtPos == config.StringSeparator)
                return transformedString.Substring(0, charPos);

            // If MaxLength ends on word, ensure it doesn't get truncated
            int length = transformedString.Length;
            int realMaxLength = config.MaxLength.Value;
            for (int i = 0; i < length; i++)
            {
                char c = transformedString[i];
                if (i <= realMaxLength || c != config.StringSeparator) continue;

                realMaxLength = i;
                break;
            }

            string result = transformedString.Substring(0, realMaxLength);
            return result;
        }
    }
}