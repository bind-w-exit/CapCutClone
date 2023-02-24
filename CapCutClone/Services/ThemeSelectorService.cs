using System;
using Windows.UI.Xaml;

namespace CapCutClone.Services
{
    internal class ThemeSelectorService : IThemeSelectorService
    {
        private readonly ILocalSettingsService _localSettingsService;
        public ThemeSelectorService(ILocalSettingsService localSettingsService)
        {
            _currentTheme = localSettingsService.GetValueOrDefault("AppTheme", ElementTheme.Light);
        }

        private ElementTheme _currentTheme;
        public ElementTheme CurrentTheme
        {
            get { return _currentTheme; }
            set
            {
                if (_currentTheme != value)
                {
                    _currentTheme = value;
                    ThemeChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler<EventArgs> ThemeChanged;
    }
}
