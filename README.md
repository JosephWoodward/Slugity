# Slugity - The highly-configurable C# Slug Generator 

Slugity is a simple, configuration based class library that's designed to create search engine friendly URL slugs.


**Simple Example:**

    var configuration = new SlugityConfig
    {
        TextCase = TextCase.LowerCase,
        StringSeparator = '-',
        MaxLength = 60
    };
    
    var slugity = new Slugity(configuration);
        
    string slug = slugity.Sanitize("A <span style="font-weight: bold">customisable</a> slug generation library");
    Console.Log(slug); 
    
    //Output: a-customisable-slug-generation-library

## Configuration options

The main goal of Slugity is  to be highly customisable, providing users with the following configuration options:

    public interface ISlugityConfig
    {
        TextCase TextCase { get; set; } 
    
        char StringSeparator { get; set; }
    
        int? MaxLength { get; set; }
    
        CharacterReplacement ReplacementCharacters { get; set; }
    
        bool EnableStopWords { get; set; }
    }

**TextCase:** The `TextCase` enumeration property allows you to specify the case of the generated slug.
Available Options: `UpperCase`, `LowerCase` and `Ignore`.

Default value: `TextCase = TextCase.LowerCase`

**StringSeparator:** The `StringSeparator` property specifies the character used to separate strings in the slug generated.

Default value: `StringSeparator = '-';`

**MaxLength:** The `MaxLength` property allows you to specify the maximum length of your generated slug. This length is calculated *after* stop-words, character replacements and invalid characters have been stripped from the slug.

Setting the `MaxLength` property to null will disable trimming of the generated slug regardless of the slug's length.

Default value: `MaxLength = 100;`

**CharacterReplacement**

**EnableStopWords:** Setting `EnableStopWords` to `true` will configure Slugity to remove a pre-defined set of stop-words from your generated slug. These stop-words are:

    string[] StopWordList =
    {
        "the", "a", "an", "am", "is", "can", "and", "or", "but", "while", "if", "then", "thus", "of", "that", "on",
        "for", "he", "we", "which", "her"
    };
