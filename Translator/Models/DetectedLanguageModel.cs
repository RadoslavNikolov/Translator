using System;
namespace Translator.Models
{
    public class DetectedLanguageModel
    {
        /// <summary>
        /// Detected language of the source bg/en/de/it etc.
        /// </summary>
        public string Language { get; set; }

        public float Score { get; set; }
    }
}
