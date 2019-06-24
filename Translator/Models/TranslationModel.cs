using System;
namespace Translator.Models
{
    public class TranslationModel
    {
        public string Text { get; set; }

        /// <summary>
        /// Language bg/en/de/it etc.
        /// </summary>
        public string To { get; set; }
    }
}
