using System;
using Windows.UI.Xaml;

namespace CapCutClone.Services
{
    public interface IThemeSelectorService
    {
        event EventHandler<EventArgs> ThemeChanged;

        ElementTheme CurrentTheme { get; set; }
    }
}
