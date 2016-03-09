using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer
{
    public class SlugCreator
    {
        private readonly IConfiguration _configuration;

        public SlugCreator()
        {
            _configuration = new DefaultConfiguration();
        }

        public SlugCreator(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Sanitize(string input)
        {
            var result = StringToUrlSanitizer.Sanitize(input);

            return result;
        }
    }
}