using CapCutClone.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using Windows.UI.Xaml;

namespace CapCutClone.ViewModels
{
    public class VideoEditorViewModel : ObservableObject
    {
        public VideoEditorViewModel(IThemeSelectorService themeSelectorService)
        {
            Theme = themeSelectorService.Theme;
            themeSelectorService.ThemeChanged += (s, e) =>
            {
                Theme = themeSelectorService.Theme;
            };
        }

        private ElementTheme theme;
        public ElementTheme Theme
        {
            get => theme;
            private set => SetProperty(ref theme, value);
        }
    }
}
