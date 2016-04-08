using Shouldly;
using Slugity.Configuration;
using Xunit;

namespace Slugity.Tests.ConfigurationTests
{
    public class ReplacementCharacterTests
    {
        [Fact]
        private void ShouldReplaceSingleWords()
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

        [Fact]
        private void ShouldNotReplaceMultipleWords()
        {
            var characters = new CharacterReplacement();
            characters.Add("Hello World", "Goodbye Planet");

            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '-',
                ReplacementCharacters = characters
            };

            var slugity = new Slugity(configuration);

            string before = "Hello World";
            string after = "hello-world";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldReplaceSeparatorIfSameChar()
        {
            var characters = new CharacterReplacement();
            characters.Add("_", "");

            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '_',
                ReplacementCharacters = characters
            };

            var slugity = new Slugity(configuration);

            string before = "Hello_World";
            string after = "helloworld";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }
    }
}