using System.Threading.Tasks;

namespace CapCutClone.Services
{
    public interface ILocalSettingsService
    {
        T GetValueOrDefault<T>(string key, T defaultValue);
        void Save<T>(string key, T value);
    }
}