using System;
using System.Collections.Generic;
using Slugity.Configuration;
using Slugity.FormattingTypes;

namespace Slugity
{
    public class Slugity
    {
        private readonly ISlugityConfig slugityConfig;

        private readonly IList<ISlugFormatter> _slugFormatters = new List<ISlugFormatter>
        {
            new CleanStringFormatter(),
            new ReplaceCharactersFormatter(),
            new StringSeparatorFormatter(),
            new TextCaseFormatter(),
            new StopWordFormatter(),
            new MaxLengthFormatter()
        };

        public Slugity()
        {
            slugityConfig = new SlugityConfig();
        }

        public Slugity(ISlugityConfig slugityConfig)
        {
            this.slugityConfig = slugityConfig;
        }

        public string GenerateSlug(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException(nameof(input));

            string transformedString = input;
            foreach (ISlugFormatter slugFormatter in _slugFormatters)
            {
                transformedString = slugFormatter.Format(transformedString, slugityConfig);
            }

            return transformedString;
        }
    }
}