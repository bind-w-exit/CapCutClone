using CapCutClone.Models;
using CapCutClone.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace CapCutClone.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel(ILocalizationService localizationService, ILocalSettingsService localSettingsService, IThemeSelectorService themeSelectorService)
        {
            LanguageItem lang = localSettingsService.GetValueOrDefault("SelectedLanguage", new LanguageItem("en-US", "English"));
            localizationService.SetLanguage(lang);

            Theme = themeSelectorService.CurrentTheme;
            themeSelectorService.ThemeChanged += (s, e) =>
            {
                Theme = themeSelectorService.CurrentTheme;
            };

            SelectedViewType = ViewTypes[0];
            OpenSettingsDialogCommand = new RelayCommand(OpenSettingsDialog);
            OpenVideoEditorWindowCommand = new RelayCommand(OpenVideoEditorWindow);
        }

        private ElementTheme theme;
        public ElementTheme Theme 
        {
            get => theme;
            set => SetProperty(ref theme, value);
        }

        public string ProjectsCount { get; set; } = "(0)";

        public ObservableCollection<string> ViewTypes { get; } = new ObservableCollection<string>() { "Grid", "List" };

        public string SelectedViewType { get; set; }

        public ICommand OpenSettingsDialogCommand { get; }

        public ICommand OpenVideoEditorWindowCommand { get; }

        private void OpenSettingsDialog()
        {
            //TODO: Write implementation for OpenSettingsDialog
        }

        private void OpenVideoEditorWindow()
        {
            //TODO: Write implementation for OpenVideoEditorWindow
        }
    }
}
