using CapCutClone.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CapCutClone.ViewModels
{
    public class SettingsViewModel : ObservableObject
    {
        private readonly SettingsService _settingsService;
        public SettingsViewModel(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }
    }
}
