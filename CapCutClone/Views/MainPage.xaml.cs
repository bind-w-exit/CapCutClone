using CapCutClone.ViewModels;
using System;
using Windows.UI.Xaml.Controls;

namespace CapCutClone.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var dialog = new SettingsDialog();
            var res = await dialog.ShowAsync();
        }
    }
}
