namespace SeoUrlSanitizer.Configuration
{
    public class DefaultConfiguration : IConfiguration
    {
        public Case ForceCase => Case.LowerCase;
    }
}