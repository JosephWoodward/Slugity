using System;
using Shouldly;
using SlugityLib.Configuration;
using Xunit;

namespace SlugityLib.Tests.ConfigurationTests
{
    public class ReplacementCharacterTests
    {
        [Fact]
        private void ShouldNotAllowEmptyBeforeValue()
        {
            var characters = new CharacterReplacement();
            Should.Throw<ArgumentException>(() => characters.Add("", "Goodbye"));
        }

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
        private void ShouldReplaceMultipleWords()
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
            string after = "goodbye-planet";

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

        [Fact]
        private void ShouldBeAbleToAddThenReplaceWords()
        {
            var characters = new CharacterReplacement();
            characters.Add("Hello", "Goodbye");

            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '_',
                ReplacementCharacters = characters
            };

            characters.AddOrReplace("Goodbye", "Hello");

            var slugity = new Slugity(configuration);

            string before = "Hello World";
            string after = "hello_world";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }

        [Fact]
        private void ShouldRemoveCharacterReplacement()
        {
            var characters = new CharacterReplacement();
            characters.Add("Hello", "Goodbye");

            var configuration = new SlugityConfig
            {
                TextCase = TextCase.LowerCase,
                StringSeparator = '_',
                ReplacementCharacters = characters
            };

            characters.Remove("Goodbye");

            var slugity = new Slugity(configuration);

            string before = "Hello World";
            string after = "hello_world";

            string result = slugity.GenerateSlug(before);
            result.ShouldBe(after);
        }
    }
}