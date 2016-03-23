using Shouldly;
using Slugity.Configuration;
using Xunit;

namespace Slugity.Tests
{
    public class DefaultFormatterTests
    {
        [Fact]
        private void StopWordsShouldBeDisabled()
        {
            var slugity = new Slugity();

            string before = "THIS AND THAT SHOULD BE LOWERCASE AND STOP WORDS DISABLED";
            string after = "this-and-that-should-be-lowercase-and-stop-words-disabled";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldHaveHyphenForSeparator()
        {
            var slugity = new Slugity();

            string before = "Text should be separated by hyphens";
            string after = "text-should-be-separated-by-hyphens";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void HtmlShouldBeStripped()
        {
            var slugity = new Slugity();

            string before = "<p>How to strip <a href=\"http://www.google.co.uk\" target=\"_blank\">html</a> from a title for <span style=\"font-weight: bold;\">seo</span> purposes</p>";
            string after = "how-to-strip-html-from-a-title-for-seo-purposes";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ExtraSpacesShouldBeRemoved()
        {
            var slugity = new Slugity();

            string before = "How    to   remove lots   of                    spaces";
            string after = "how-to-remove-lots-of-spaces";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }
    }
}