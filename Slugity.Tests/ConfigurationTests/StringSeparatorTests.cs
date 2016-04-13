using Shouldly;
using SlugityLib.Configuration;
using Xunit;

namespace SlugityLib.Tests.ConfigurationTests
{
    public class StringSeparatorTests
    {
        [Fact]
        private void ShouldSeparateStrings()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '-'
            };

            var slugity = new Slugity(configuration);

            string before = "Spaces should be replaced with chosen string separator";
            string after = "spaces-should-be-replaced-with-chosen-string-separator";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldTrimAdditionalSpaces()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = ' '
            };

            var slugity = new Slugity(configuration);

            string before = "Additional      spaces should                  be                                  trimmed";
            string after = "additional spaces should be trimmed";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }
    }
}