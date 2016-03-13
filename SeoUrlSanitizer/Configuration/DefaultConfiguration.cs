namespace SeoUrlSanitizer.Configuration
{
    public abstract class DefaultConfiguration : IConfiguration
    {
        protected DefaultConfiguration()
        {
            TextCase = TextCase.LowerCase;
            StringSeparator = "-";
        }

        public TextCase TextCase { get; set; }

        public string StringSeparator { get; set; }
    }
}