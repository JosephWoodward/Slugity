# Slug Generator

Slug generator is a simple configuration based class library that's designed to create search engine friendly URL slugs.


**Simple Example:**

    var configuration = new SlugConfiguration
    {
        TextCase = TextCase.LowerCase,
        StringSeparator = '-',
        MaxLength = 60
    };
    
    var sanitizer = new SlugCreator(configuration);
        
    string slug = sanitizer.Sanitize("A customisable slug generation library");
    Console.Log(slug); 
    
    //Output: a-customisable-slug-generation-library

## Configuration options

The main goal of Slug Generator is  to be highly customisable, providing users with the following configuration options:

    public interface IConfiguration
    {
        TextCase TextCase { get; set; } 
    
        char StringSeparator { get; set; }
    
        int? MaxLength { get; set; }
    
        CharacterReplacement ReplacementCharacters { get; set; }
    
        bool EnableStopWords { get; set; }
    }

**TextCase**

The TextCase enumeration allows you to specify the case of the generated slug.
Choices include `UpperCase`, `LowerCase` and `Ignore`.

Default configuration: `LowerCase`

**StringSeparator**

**MaxLength**

**CharacterReplacement**

**EnableStopWords**
