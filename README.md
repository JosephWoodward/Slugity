# Slug Generator

A simple configuration based class library to create URL slugs.

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
