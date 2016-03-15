using Shouldly;
using Xunit;

namespace SeoUrlSanitizer.Tests
{
    public class CustomConfigurationTests
    {
        [Fact]
        private void ShouldBeLowerCase()
        {
            var customConfigration = new CustomConfiguration();

            var sanitizer = new SlugCreator(customConfigration);

            string before = "THIS SHOULD BE LOWERCASE";
            string after = "this should be lowercase";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }
    }
}