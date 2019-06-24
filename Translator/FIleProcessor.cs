using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Translator.Infrastructure;
using Translator.Infrastructure.Interfaces;
using Translator.Models;
using Extensions = Translator.Infrastructure.Extensions;

namespace Translator
{
    public class FIleProcessor
    {
        private readonly ITranslationService _translationService;

        public FIleProcessor(string endpoint, string key)
        {
            _translationService = new TranslationService(endpoint, key);
        }

        public FileInfo ProcessFile(string path, DirectoryInfo destinationDir)
        {
            var file = new FileInfo(path);
            if (!file.Exists)
            {
                throw new FileNotFoundException($"{file.FullName} does not exist");
            }

            if (!destinationDir.Exists)
            {
                throw new DirectoryNotFoundException($"{destinationDir.FullName} does not exist");
            }

            var data = File.ReadAllText(file.FullName);
            XDocument doc = XDocument.Parse(data);

            var source = new Dictionary<string, string>();
            var elements = (from x in doc.Descendants("data") select x).ToList();
            foreach (var element in elements)
            {
                if (element.HasAttributes)
                {
                    var name = element.Attribute("name")?.Value ?? "";
                    if (!source.ContainsKey(name) && !name.ToLower().Contains("font_name"))
                    {
                        source.Add(name, element.Descendants("value").FirstOrDefault()?.Value ?? "");
                    }
                }
            }

            var translateSource = source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / 100)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();

            var resultDict = Extensions.CloneDictionaryCloningValues(source);
            foreach (var s in translateSource)
            {
                var result = _translationService.Translate(s.Select(x => x.Value).ToList(), "en", "bg");
                foreach (KeyValuePair<string, AzureTranslateResultModel> model in result)
                {
                    var toEdit = resultDict.FirstOrDefault(x => x.Value.Equals(model.Key, StringComparison.OrdinalIgnoreCase));
                    if (!string.IsNullOrEmpty(toEdit.Key))
                    {
                        resultDict[toEdit.Key] = model.Value.Translations.FirstOrDefault(x => x.To == "bg")?.Text??"";
                    }
                }
            }

            foreach (var element in elements)
            {
                
                if (element.HasAttributes)
                {
                    var name = element.Attribute("name")?.Value ?? "";
                    if (resultDict.TryGetValue(name, out string translatedVal) && !string.IsNullOrEmpty(translatedVal))
                    {
                        var xmlValElement = element.Descendants("value").FirstOrDefault();
                        if (xmlValElement != null)
                        {
                            xmlValElement.Value = translatedVal;
                        }
                    }
                }
            }

            var newFileFullPath = Path.Combine(destinationDir.FullName, file.Name);
            doc.Save(newFileFullPath);

            return new FileInfo(newFileFullPath);
        }
    }
}
