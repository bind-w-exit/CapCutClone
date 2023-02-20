using CapCutClone.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using System;
using Windows.UI.Xaml.Controls;

namespace CapCutClone.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetRequiredService<MainViewModel>();
        }

        public MainViewModel ViewModel => (MainViewModel)DataContext;

        private async void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var dialog = new SettingsDialog();
            var res = await dialog.ShowAsync();
        }
    }
}
