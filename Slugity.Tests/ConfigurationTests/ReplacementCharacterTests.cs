using Shouldly;
using Slugity.Configuration;
using Xunit;

namespace Slugity.Tests.ConfigurationTests
{
    public class ReplacementCharacterTests
    {
        [Fact]
        private void CharactersShouldBeReplaced()
        {
            var characters = new CharacterReplacement();
            characters.Add("Hello", "Goodbye");

            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '-',
                ReplacementCharacters = characters
            };

            var slugity = new Slugity(configuration);

            string before = "Hello World";
            string after = "goodbye-world";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

    }
}