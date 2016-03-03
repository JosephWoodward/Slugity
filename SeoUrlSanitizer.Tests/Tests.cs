using Shouldly;
using Xunit;

namespace SeoUrlSanitizer.Tests
{
    public class Tests
    {
        [Fact]
        public void SanitizeText()
        {
            string title = "How to sanitize a url for seo purposes";
            string result = "how-to-sanitize-a-url-for-seo-purposes";

            SeoUrlSanitizer.Sanitize(title).ShouldBe(result);
        }

        [Fact]
        public void StripHtmlTags()
        {
            string title = "<p>How to sanitize a <a href=\"http://www.google.co.uk\" target=\"_blank\">url</a> for <span style=\"font-weight: bold;\">seo</span> purposes</p>";
            string result = "how-to-sanitize-a-url-for-seo-purposes";

            SeoUrlSanitizer.Sanitize(title).ShouldBe(result);
        }


        [Fact]
        public void RemoveStopWords()
        {
            string title = "How to sanitize a url for seo purposes and remove stop words";
            string result = "how-sanitize-url-seo-purposes-remove-stop-words";

            SeoUrlSanitizer.Sanitize(title, true).ShouldBe(result);
        }
    }
}