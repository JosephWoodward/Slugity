using Shouldly;
using SlugityLib.Configuration;
using Xunit;

namespace SlugityLib.Tests.ConfigurationTests
{
    public class MaxLengthTests
    {
        [Fact]
        private void ShouldNotTrimSlugIfMaxLengthIsNull()
        {
            var configuration = new SlugityConfig
            {
                MaxLength = null
            };

            var slugity = new Slugity(configuration);

            string before = "This should not be trimmed";
            string after = "this-should-not-be-trimmed";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldNotTrimSlugIfMaxLengthGreater()
        {
            var configuration = new SlugityConfig
            {
                MaxLength = 28
            };

            var slugity = new Slugity(configuration);

            string before = "This should not be trimmed";
            string after = "this-should-not-be-trimmed";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldTruncateTrailingSeparator()
        {
            var configuration = new SlugityConfig
            {
                MaxLength = 34
            };

            var slugity = new Slugity(configuration);

            string before = "Test to see if the next separator gets truncated";
            string after = "test-to-see-if-the-next-separator";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldNotTruncateWord()
        {
            var configuration = new SlugityConfig
            {
                MaxLength = 10
            };

            var slugity = new Slugity(configuration);

            string before = "The word hippo should not be truncated";
            string after = "the-word-hippo";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }
    }
}