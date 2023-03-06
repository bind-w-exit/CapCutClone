using CapCutClone.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using Windows.UI.Xaml;

namespace CapCutClone.ViewModels
{
    public class VideoEditorViewModel : ObservableObject
    {
        public VideoEditorViewModel(IThemeSelectorService themeSelectorService)
        {
            Theme = themeSelectorService.CurrentTheme;
            themeSelectorService.ThemeChanged += (s, e) =>
            {
                Theme = themeSelectorService.CurrentTheme;
            };
        }

        private ElementTheme theme;
        public ElementTheme Theme
        {
            get => theme;
            set => SetProperty(ref theme, value);
        }
    }
}
