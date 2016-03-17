using Shouldly;
using Slugity.Configuration;
using Xunit;

namespace Slugity.Tests.ConfigurationTests
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

            var sanitizer = new Slugity(configuration);

            string before = "This should not be trimmed";
            string after = "this-should-not-be-trimmed";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldNotTrimSlugIfMaxLengthGreater()
        {
            var configuration = new SlugityConfig
            {
                MaxLength = 28
            };

            var sanitizer = new Slugity(configuration);

            string before = "This should not be trimmed";
            string after = "this-should-not-be-trimmed";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldTruncateTrailingSeparator()
        {
            var configuration = new SlugityConfig
            {
                MaxLength = 34
            };

            var sanitizer = new Slugity(configuration);

            string before = "Test to see if the next separator gets truncated";
            string after = "test-to-see-if-the-next-separator";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldNotTruncateWord()
        {
            var configuration = new SlugityConfig
            {
                MaxLength = 10
            };

            var sanitizer = new Slugity(configuration);

            string before = "The word hippo should not be truncated";
            string after = "the-word-hippo";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }
    }
}