using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer
{
    public class SlugCreator
    {
        private readonly IConfiguration _configuration;

        public SlugCreator()
        {
            _configuration = new SlugConfiguration();
        }

        public SlugCreator(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Sanitize(string input)
        {
            var result = StringToUrlSanitizer.Sanitize(input);
            if (_configuration.TextCase == TextCase.Ignore) return input;

            return _configuration.TextCase == TextCase.LowerCase ? result.ToLower() : result.ToUpper();
        }
    }
}