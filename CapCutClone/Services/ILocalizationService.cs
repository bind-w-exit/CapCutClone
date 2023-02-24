using System.Collections.Generic;
using System.Threading.Tasks;
using CapCutClone.Models;

namespace CapCutClone.Services
{
    public interface ILocalizationService
    {
        List<LanguageItem> Languages { get; }

        LanguageItem GetCurrentLanguageItem();

        void SetLanguage(LanguageItem languageItem);
    }
}