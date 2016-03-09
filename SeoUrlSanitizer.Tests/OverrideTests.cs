using Shouldly;
using Xunit;

namespace SeoUrlSanitizer.Tests
{
    public class OverrideTests
    {
        [Fact]
        public void SanitizeText()
        {
            var sanitizer = new SlugCreator();

            string before = "THIS-SHOULD-BE-FORCED-LOWERCASE";
            string after = "this-should-be-forced-lowercase";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }
    }
}