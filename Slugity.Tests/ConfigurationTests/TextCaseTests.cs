using Shouldly;
using Slugity.Configuration;
using Xunit;

namespace Slugity.Tests.ConfigurationTests
{
    public class TextCaseTests
    {
        [Fact]
        private void ShouldBeLowerCase()
        {
            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase
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