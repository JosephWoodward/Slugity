using Shouldly;
using Slugity;
using SlugityLib.Configuration;
using Xunit;

namespace SlugityLib.Tests.ConfigurationTests
{
    public class StopWordTests
    {
        [Fact]
        private void ShouldStripStopWords()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '-',
                StripStopWords = true
            };

            var slugity = new Slugity(configuration);

            string before = "This then that should be stripped";
            string after = "this-should-be-stripped";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldStripCustomStopWords()
        {
            var stopWords = new StopWords();
            stopWords.Add("just", "testing");
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '-',
                StripStopWords = true,
                StopWords = stopWords
            };

            var slugity = new Slugity(configuration);

            string before = "This then that just testing should be stripped";
            string after = "this-should-be-stripped";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldLeaveStopWords()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '-',
                StripStopWords = false,
            };

            var slugity = new Slugity(configuration);

            // Broken
            string before = "This then that should not be stripped";
            string after = "this-then-that-should-not-be-stripped";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }
    }
}