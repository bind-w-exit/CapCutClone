using Windows.Storage;

namespace CapCutClone.Services
{
    public class LocalSettingsService : ILocalSettingsService
    {
        public T GetValueOrDefault<T>(string key, T defaultValue)
        {
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey(key))
            {
                return (T)ApplicationData.Current.LocalSettings.Values[key];
            }
            
            return defaultValue;
        }

        public void Save<T>(string key, T value)
        {
            
        }
    }
}