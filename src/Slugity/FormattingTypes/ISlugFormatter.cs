using SlugityLib.Configuration;

namespace SlugityLib.FormattingTypes
{
    public interface ISlugFormatter
    {
        string Format(string transformedString, ISlugityConfig config);
    }
}