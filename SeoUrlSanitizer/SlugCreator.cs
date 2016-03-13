using System;
using System.Collections.Generic;
using SeoUrlSanitizer.Configuration;
using SeoUrlSanitizer.FormattingTypes;

namespace SeoUrlSanitizer
{
    public class SlugCreator
    {
        private readonly IConfiguration _configuration;

        private readonly IList<ISlugFormatter> _slugFormatters = new List<ISlugFormatter>
        {
            new TextCaseFormatter(),
            new MaxLengthFormatter(),
            new StopWordFormatter(),
            new StringSeparatorFormatter()
        };

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
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException(nameof(input));

            string transformedString = input;
            foreach (ISlugFormatter slugFormatter in _slugFormatters)
            {
                transformedString = slugFormatter.Format(transformedString, _configuration);
            }

            return transformedString;
        }
    }
}