namespace SeoUrlSanitizer.Configuration
{
    public abstract class DefaultConfiguration : IConfiguration
    {
        protected DefaultConfiguration()
        {
            TextCase = TextCase.LowerCase;
            Separator = "-";
        }

        public TextCase TextCase { get; set; }

        public string Separator { get; set; }
    }
}