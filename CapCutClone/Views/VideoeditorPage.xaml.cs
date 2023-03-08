using CapCutClone.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CapCutClone.Views
{
    public sealed partial class VideoEditorPage : Page
    {
        public VideoEditorPage()
        {
            DataContext = Ioc.Default.GetRequiredService<VideoEditorViewModel>();
            InitializeComponent();
            Window.Current.SetTitleBar(AppTitleBar);
        }

        public VideoEditorViewModel ViewModel => (VideoEditorViewModel)DataContext;

        private async void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SettingsDialog();
            var res = await dialog.ShowAsync();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ShortcutDialog();
            var res = await dialog.ShowAsync();
        }
    }
}
