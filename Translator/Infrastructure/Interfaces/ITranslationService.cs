using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Models;

namespace Translator.Infrastructure.Interfaces
{
    public interface ITranslationService : IDisposable
    {
        /// <summary>
        /// Превежда списък от текстове използвайки Microsoft Azure Cognitive Services.
        /// </summary>
        /// <param name="source">Данните,които ще се превеждат.</param>
        /// <param name="from">Езикът на входните данни. Не е задължителен.</param>
        /// <param name="to">Езикът на превода. Освен него по подразбиране ще добави и превод на En.</param>
        /// <returns></returns>
        IDictionary<string, AzureTranslateResultModel> Translate(IList<string> source, string from, string to);
    }
}
