using System.Collections.Generic;

namespace Translator.Models
{
    public class AzureTranslateResultModel
    {
        public DetectedLanguageModel DetectedLanguage { get; set; }
        public List<TranslationModel> Translations { get; set; }
    }
}
