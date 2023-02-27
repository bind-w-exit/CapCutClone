using CapCutClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.ApplicationModel.Resources.Core;

namespace CapCutClone.Services
{
    public class LocalizationService : ILocalizationService
    {
        private LanguageItem _currentLanguageItem;

        private readonly ResourceManager _resourceManager;
        private readonly ResourceContext _resourceContext;

        public LocalizationService()
        {
            _resourceContext = new ResourceContext();
            _resourceManager = ResourceManager.Current;
            RegisterLanguageFromResource();
        }

        public List<LanguageItem> Languages { get; } = new List<LanguageItem>();

        public LanguageItem GetCurrentLanguageItem() => _currentLanguageItem;

        public void SetLanguage(LanguageItem languageItem)
        {
            
            if (Languages.Any(fruit => fruit.Tag == languageItem.Tag))
            {
                //_currentLanguageItem = languageItem;
                _currentLanguageItem = Languages.Find(lang => lang.Tag == languageItem.Tag);
                Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = languageItem.Tag;
                _resourceContext.QualifierValues["Language"] = languageItem.Tag;
            }
        }

        private void RegisterLanguageFromResource()
        {
            ResourceMap resourceMap = _resourceManager.MainResourceMap.GetSubtree("LanguageList");

            foreach (var resource in resourceMap)
            {
                var candidates = resource.Value.Candidates;
                foreach (var candidate in candidates)
                {
                    var value = candidate.ValueAsString;
                    if (!string.IsNullOrEmpty(value))
                    {
                        Languages.Add(new LanguageItem(resource.Key, value));
                    }
                }
            }
        }
    }
}
