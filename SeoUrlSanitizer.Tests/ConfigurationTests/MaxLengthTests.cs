using SeoUrlSanitizer.Configuration;
using Shouldly;
using Xunit;

namespace SeoUrlSanitizer.Tests.ConfigurationTests
{
    public class MaxLengthTests
    {
        [Fact]
        private void ShouldNotTrimSlug()
        {
            var configuration = new SlugConfiguration
            {
                MaxLength = 25
            };

            var sanitizer = new SlugCreator(configuration);

            string before = "This should be replaced";
            string after = "this-should-be-replaced";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldTruncateTrailingSeparator()
        {
            var configuration = new SlugConfiguration
            {
                MaxLength = 5
            };

            var sanitizer = new SlugCreator(configuration);

            string before = "Test to see if the word hippo gets truncated";
            string after = "test";

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