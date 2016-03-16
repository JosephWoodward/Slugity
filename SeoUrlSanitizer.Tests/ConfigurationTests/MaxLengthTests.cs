using SeoUrlSanitizer.Configuration;
using Shouldly;
using Xunit;

namespace SeoUrlSanitizer.Tests.ConfigurationTests
{
    public class MaxLengthTests
    {
        [Fact]
        private void ShouldNotTrimSlugIfMaxLengthIsNull()
        {
            var configuration = new SlugConfiguration
            {
                MaxLength = null
            };

            var sanitizer = new SlugCreator(configuration);

            string before = "This should not be trimmed";
            string after = "this-should-not-be-trimmed";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldNotTrimSlugIfMaxLengthGreater()
        {
            var configuration = new SlugConfiguration
            {
                MaxLength = 28
            };

            var sanitizer = new SlugCreator(configuration);

            string before = "This should not be trimmed";
            string after = "this-should-not-be-trimmed";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldTruncateTrailingSeparator()
        {
            var configuration = new SlugConfiguration
            {
                MaxLength = 34
            };

            var sanitizer = new SlugCreator(configuration);

            string before = "Test to see if the next separator gets truncated";
            string after = "test-to-see-if-the-next-separator";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldNotTruncateWord()
        {
            var configuration = new SlugConfiguration
            {
                MaxLength = 10
            };

            var sanitizer = new SlugCreator(configuration);

            string before = "The word hippo should not be truncated";
            string after = "the-word-hippo";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }
    }
}