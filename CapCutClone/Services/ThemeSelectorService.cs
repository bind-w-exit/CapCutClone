using System;
using Windows.UI.Xaml;

namespace CapCutClone.Services
{
    public class ThemeSelectorService : IThemeSelectorService
    {
        private readonly ILocalSettingsService _localSettingsService;

        public ThemeSelectorService(ILocalSettingsService localSettingsService)
        {
            _localSettingsService = localSettingsService;
            _theme = _localSettingsService.GetValueOrDefault("AppTheme", ElementTheme.Default);
        }

        private ElementTheme _theme;
        public ElementTheme Theme
        {
            get { return _theme; }
            set
            {
                if (_theme != value)
                {
                    _theme = value;
                    _localSettingsService.Save("AppTheme", value);
                    ThemeChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler<EventArgs> ThemeChanged;
    }
}
