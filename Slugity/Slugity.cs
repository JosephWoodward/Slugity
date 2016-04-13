using System;
using System.Collections.Generic;
using SlugityLib.Configuration;
using SlugityLib.FormattingTypes;

namespace SlugityLib
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

        /// <summary>
        /// Generate a slug based on input and optional configuration settings
        /// </summary>
        /// <param name="input">String you would like to turn into a slug</param>
        /// <returns>Slug based on configuration settings</returns>
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