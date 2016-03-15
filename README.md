# Slug Generator

Slug generator is a simple configuration based class library that's designed to create SEO friendly URL slugs.

## Configuration options

- Ability to force desired text case (`UpperCase`, `LowerCase` or `Ignore`)
- Maximum length of slug

Example:

    var configuration = new SlugConfiguration
    {
        TextCase = TextCase.LowerCase,
        StringSeparator = "-",
        MaxLength = 60
    };
    
    var sanitizer = new SlugCreator(configuration);
    
    string before = "A simple slug generation library";
    string after = "";
    
    string output = sanitizer.Sanitize("A simple slug generation library");
    // Output: a-simple-slug-generation-library
