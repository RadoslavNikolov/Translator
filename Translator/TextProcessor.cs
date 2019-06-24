using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Translator.Infrastructure;
using Translator.Infrastructure.Interfaces;

namespace Translator
{
    public class TextProcessor
    {
        private readonly ITranslationService _translationService;

        public TextProcessor(string endpoint, string key)
        { 
            _translationService = new TranslationService(endpoint, key);
        }

        public string Translate(string source)
        {
            var result = _translationService.Translate(new List<string>(){source}, "en", "bg");
            var str = string.Join(Environment.NewLine, result.Values.Select(x => x.Translations.FirstOrDefault(t => t.To == "bg")?.Text).ToArray());

            return str;
        }
    }
}
