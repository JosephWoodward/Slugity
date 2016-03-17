using Slugity.Configuration;

namespace Slugity.FormattingTypes
{
    public interface ISlugFormatter
    {
        string Format(string transformedString, ISlugityConfig config);
    }
}