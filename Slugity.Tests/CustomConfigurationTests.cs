using Shouldly;
using Xunit;

namespace Slugity.Tests
{
    public class CustomConfigurationTests
    {
        [Fact]
        private void ShouldBeLowerCase()
        {
            var customConfigration = new CustomSlugityConfig();

            var sanitizer = new Slugity(customConfigration);

            string before = "THIS SHOULD BE LOWERCASE";
            string after = "this should be lowercase";

            string result = sanitizer.Sanitize(before);
            result.ShouldBe(after);
        }
    }
}