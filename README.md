# Slugity - The highly configurable C# slug generator 

Slugity is a simple, configuration based class library that's designed to create search engine friendly URL slugs.

##Features

- Super easy to use
- Highly configurable (see below for configuration options)
- Cleans strings
- Strips HTML


**Simplest Example:**

    var slugity = new Slugity();
    string slug = slugity.GenerateSlug("A <span style="font-weight: bold">customisable</a> slug generation library");
    
    Console.Log(slug); 
    //Output: a-customisable-slug-generation-library

**Configuration Example:**

    var configuration = new SlugityConfig
    {
        TextCase = TextCase.LowerCase,
        StringSeparator = '_',
        MaxLength = 60
    };
    
    configuration.ReplacementCharacters.Add("eat", "munch on");
    
    var slugity = new Slugity(configuration);
    string slug = slugity.GenerateSlug("I like to eat lettuce");
    
    Console.Log(slug);
    //Output: i_like_to_munch_on_lettuce

## Configuration options

The main goal of Slugity is to be highly configuration, providing users with the following options:

    public interface ISlugityConfig
    {
        TextCase TextCase { get; set; } 
    
        char StringSeparator { get; set; }
    
        int? MaxLength { get; set; }
    
        CharacterReplacement ReplacementCharacters { get; set; }
    
        bool StripStopWords { get; set; }
    }

**TextCase**   
The `TextCase` enumeration property allows you to specify the case of the generated slug.
Available Options: `UpperCase`, `LowerCase` and `Ignore`.

Default value: `TextCase = TextCase.LowerCase`

**StringSeparator**   
The `StringSeparator` property specifies the character used to separate strings in the slug generated.

Default value: `StringSeparator = '-';`

**MaxLength**   
The `MaxLength` property allows you to specify the maximum length of your generated slug. This length is calculated *after* stop-words, character replacements and invalid characters have been stripped from the slug. Setting the `MaxLength` property to null will disable trimming of the generated slug regardless of the slug's length.

Default value: `MaxLength = 100;`

**ReplacementCharacters**   
Slugity's `ReplacementCharacters` property gives you the control to replace certain words or letters from your generated slug.

Example:

    var configuration = new SlugityConfig
    {
        TextCase = TextCase.Ignore,
        StringSeparator = ' '
    };

    configuration.ReplacementCharacters.Add("Hello", "Goodbye");

    var slugity = new Slugity(configuration);
    string result = slugity.GenerateSlug("Hello World");

    Console.WriteLine(result); // Goodbye World


**StripStopWords**  
Setting `StripStopWords` to `true` will configure Slugity to remove a pre-defined set of stop-words from your generated slug. See [here](http://blogs.iit.edu/iit_web/2013/04/29/seo-the-evil-stop-words/) for more information on stop words. 

Default value: `StripStopWords = false;`

The current stop-words are:

    string[] StopWordList =
    {
        "the", "a", "an", "am", "is", "can", "and", "or", "but", "while", "if", "then", "thus", "of", "that", "on",
        "for", "he", "we", "which", "her"
    };
    
Example:

    var configuration = new SlugityConfig
    {
        TextCase = TextCase.LowerCase,
        StringSeparator = ' ',
        StripStopWords = true
    };

    var slugity = new Slugity(configuration);

    string before = "This then that should remain";

    string result = slugity.GenerateSlug("This then that should remain");
    Console.WriteLine(result); // this should remain

## Installation

You can install Slugity by copying and pasting the following command into your Package Manager Console within Visual Studio (Tools > NuGet Package Manager > Package Manager Console).

`Install-Package Slugity`
