using Shouldly;
using Xunit;

namespace SeoUrlSanitizer.Tests
{
    public class DefaultFormatterTests
    {
        [Fact]
        private void ShouldBeLowerCase()
        {
            var sanitizer = new SlugCreator();

            string before = "THIS SHOULD BE LOWERCASE";
            string after = "this-should-be-lowercase";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void StopWordsShouldBeDisabled()
        {
            var sanitizer = new SlugCreator();

            string before = "THIS AND THAT SHOULD BE LOWERCASE AND STOP WORDS DISABLED";
            string after = "this-and-that-should-be-lowercase-and-stop-words-disabled";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldHaveHyphenForSeparator()
        {
            var sanitizer = new SlugCreator();

            string before = "Text should be separated by hyphens";
            string after = "text-should-be-separated-by-hyphens";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void HtmlShouldBeStripped()
        {
            var sanitizer = new SlugCreator();

            string before = "<p>How to strip <a href=\"http://www.google.co.uk\" target=\"_blank\">html</a> from a title for <span style=\"font-weight: bold;\">seo</span> purposes</p>";
            string after = "how-to-strip-html-from-a-title-for-seo-purposes";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ExtraSpacesShouldBeRemoved()
        {
            var sanitizer = new SlugCreator();

            string before = "How    to   remove lots   of                    spaces";
            string after = "how-to-remove-lots-of-spaces";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }
    }
}