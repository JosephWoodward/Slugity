using Shouldly;
using SlugityLib.Configuration;
using Xunit;

namespace SlugityLib.Tests.ConfigurationTests
{
    public class TextCaseTests
    {
        [Fact]
        private void ShouldBeUpperCase()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.UpperCase,
                StringSeparator = '-'
            };

            var slugity = new Slugity(configuration);

            string before = "this should BE UPPERCASE";
            string after = "THIS-SHOULD-BE-UPPERCASE";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldBeLowerCase()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '-'
            };

            var slugity = new Slugity(configuration);

            string before = "THIS SHOULD BE LOWERCASE";
            string after = "this-should-be-lowercase";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldBeCamalCase()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.CamalCase,
                StringSeparator = '-'
            };

            var slugity = new Slugity(configuration);

            string before = "this should BE CAMAL CASE";
            string after = "This-Should-Be-Camal-Case";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }
    }
}