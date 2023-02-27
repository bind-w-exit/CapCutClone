using CapCutClone.Helpers;
using System.Threading.Tasks;
using Windows.Storage;

namespace CapCutClone.Services
{
    public class LocalSettingsService : ILocalSettingsService
    {
        public T GetValueOrDefault<T>(string key, T defaultValue)
        {
            if (ApplicationData.Current.LocalSettings.Values.TryGetValue(key, out var obj))
            {
                return Json.ToObject<T>((string)obj);
            }

            return defaultValue;
        }

        public void Save<T>(string key, T value)
        {
            ApplicationData.Current.LocalSettings.Values[key] = Json.Stringify(value);
        }
    }
}