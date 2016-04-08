using Shouldly;
using Slugity.Configuration;
using Xunit;

namespace Slugity.Tests.ConfigurationTests
{
    public class StopWordTests
    {
        [Fact]
        private void ShouldRemoveStopWords()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '-',
                EnableStopWords = true
            };

            var slugity = new Slugity(configuration);

            // Broken
            string before = "This then that should be stripped";
            string after = "this-should-be-stripped";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }
    }
}