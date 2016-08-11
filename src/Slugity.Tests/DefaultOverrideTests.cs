// using SlugityLib.Configuration;
// using Shouldly;
// using Xunit;

// namespace SeoUrlSanitizer.Tests
// {
//     public class DefaultOverrideTests
//     {
//         [Fact]
//         public void ForceLowerCaseText()
//         {
//             var sanitizer = new SlugCreator();

//             string before = "THIS-SHOULD-BE-FORCED-LOWERCASE";
//             string after = "this-should-be-forced-lowercase";

//             string result = sanitizer.Sanitize(before);
//             result.ShouldBe(after);
//         }

//         [Fact]
//         public void ForceUpperCaseText()
//         {
//             var config = new SlugConfiguration
//             {
//                 TextCase = TextCase.UpperCase
//             };

//             var sanitizer = new SlugCreator(config);

//             string before = "this-should-be-forced-lowercase";
//             string after = "THIS-SHOULD-BE-FORCED-LOWERCASE";

//             string result = sanitizer.Sanitize(before);
//             result.ShouldBe(after);
//         }

//         [Fact]
//         public void IgnoreTextCase()
//         {
//             var config = new SlugConfiguration
//             {
//                 TextCase = TextCase.Ignore
//             };

//             var sanitizer = new SlugCreator(config);

//             string before = "This-ShouLd-Be-Left-HOw-It-iS";
//             string after = "This-ShouLd-Be-Left-HOw-It-iS";

//             string result = sanitizer.Sanitize(before);
//             result.ShouldBe(after);
//         }


//         [Fact]
//         public void SeparatorTests()
//         {
//             var config = new SlugConfiguration
//             {
//                 Separator = "-"
//             };

//             var sanitizer = new SlugCreator(config);

//             string before = "separate this text with hyphens";
//             string after = "separate-this-text-with-hyphens";

//             string result = sanitizer.Sanitize(before);
//             result.ShouldBe(after);
//         }

//         [Fact]
//         public void SeparatorTests2()
//         {
//             var config = new SlugConfiguration
//             {
//                 Separator = "_"
//             };

//             var sanitizer = new SlugCreator(config);

//             string before = "separate this text with hyphens";
//             string after = "separate_this_text_with_hyphens";

//             string result = sanitizer.Sanitize(before);
//             result.ShouldBe(after);
//         }


//     }
// }