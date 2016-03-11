using System;
using System.Collections.Generic;
using System.Text;
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
            new SeparatorFormatter(),
            new StopWordFormatter()
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

            var finalString = new StringBuilder();
            foreach (ISlugFormatter slugFormatter in this._slugFormatters)
            {
                string formatResult = slugFormatter.Format(input, finalString, this._configuration);
                finalString.Append(formatResult);
            }

            return finalString.ToString();
        }
    }
}