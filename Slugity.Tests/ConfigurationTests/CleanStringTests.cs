using Shouldly;
using SlugityLib.Configuration;
using Xunit;

namespace SlugityLib.Tests.ConfigurationTests
{
    public class CleanStringTests
    {
        [Fact]
        private void ShouldCleanString()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '-'
            };

            var slugity = new Slugity(configuration);

            string before = "This should clear the text, ok?";
            string after = "this-should-clear-the-text-ok";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldCleanString2()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '-'
            };

            var slugity = new Slugity(configuration);

            string before = "Clean & tidy strings, this***.";
            string after = "clean-tidy-strings-this";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }   

        [Fact]
        private void ShouldCleanStrings3()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '-'
            };

            configuration.ReplacementCharacters.Add("remain", "be left behind");

            var slugity = new Slugity(configuration);

            string before = "text !\"£$%^&*(),>/#'; should remain";
            string after = "text-should-be-left-behind";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }
    }
}