using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Translator.Infrastructure.Interfaces;
using Translator.Models;

namespace Translator.Infrastructure
{
    public class TranslationService : ITranslationService
    {
        private readonly string _endPoint;
        private readonly string _key;
        private bool disposed;
        public TranslationService(string endPoint, string key)
        {
            _endPoint = endPoint;
            _key = key;
        }
        /// <summary>
        /// Превежда списък от текстове използвайки Microsoft Azure Cognitive Services.
        /// </summary>
        /// <param name="source">Данните,които ще се превеждат.</param>
        /// <param name="from">Езикът на входните данни. Не е задължителен.</param>
        /// <param name="to">Езикът на превода. Освен него по подразбиране ще добави и превод на En.</param>
        /// <returns></returns>
        public IDictionary<string, AzureTranslateResultModel> Translate(IList<string> source, string from, string to)
        {
            if (!source.Any(x => !string.IsNullOrWhiteSpace(x)))
            {
                throw new ArgumentNullException("Empty source");
            }

            var route = "/translate?api-version=3.0";
            // Ако не е посочен език на входните данни ще се извърши автоматично разпознаване.
            if (!string.IsNullOrWhiteSpace(from))
            {
                route += $"&from={from.Trim().ToLower()}";
            }

            // Добавя параметър за език на превод
            if (!string.IsNullOrWhiteSpace(to))
            {
                route += $"&to={to.Trim().ToLower()}";
            }

            // Автоматично добавя En като допълнителен език на превод, ако не е дефиниан като такъв.
            if (string.IsNullOrWhiteSpace(to) || !to.Trim().Equals("en", StringComparison.OrdinalIgnoreCase))
            {
                route += "&to=en";
            }

            // Автоматично добавя дефинираният език на входните данни и като такъв на превод.
            // Изпозлва се за ключовете на Dictionary<string, AzureTranslateResultModel>
            if (!string.IsNullOrWhiteSpace(from) && !from.Trim().Equals("en", StringComparison.OrdinalIgnoreCase))
            {
                route += $"&to={from.Trim().ToLower()}";
            }

            var body = source.Select(x => new { Text = x }).ToArray();
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(_endPoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");

                // Добавяне на хедър за аутентикация
                request.Headers.Add("Ocp-Apim-Subscription-Key", _key);

                // Изпращане на заяввка
                var response = client.SendAsync(request).Result;
                var jsonResponse = response.Content.ReadAsStringAsync().Result;

                var result = JsonConvert.DeserializeObject<IList<AzureTranslateResultModel>>(jsonResponse);
                var resultDict = new Dictionary<string, AzureTranslateResultModel>();
                foreach (var azureTranslateResultModel in result.Where(x => x.Translations != null && x.Translations.Any(t => t.To.Equals(to, StringComparison.OrdinalIgnoreCase))))
                {
                    var key = azureTranslateResultModel.Translations.FirstOrDefault(t => t.To.Equals(from, StringComparison.OrdinalIgnoreCase))?.Text??Guid.NewGuid().ToString();
                    if (!resultDict.ContainsKey(key))
                    {
                        resultDict[key] = azureTranslateResultModel;
                    }
                }
                
                return resultDict;
            }
        }

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                // Free any other managed objects here.
                
            }

            // Free any unmanaged objects here.
            disposed = true;
        }

        ~TranslationService()
        {
            Dispose(false);
        }
    }
}
