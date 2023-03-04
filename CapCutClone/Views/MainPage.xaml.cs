using CapCutClone.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using System;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CapCutClone.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {         
            DataContext = Ioc.Default.GetRequiredService<MainViewModel>();
            InitializeComponent();
            Window.Current.SetTitleBar(AppTitleBar);
        }

        public MainViewModel ViewModel => (MainViewModel)DataContext;

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SettingsDialog();
            var res = await dialog.ShowAsync();
        }

        // I'm just trying change the window state to maximized ＞﹏＜
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Get the current screen metrics
            DisplayInformation displayInfo = DisplayInformation.GetForCurrentView();
            var scale = displayInfo.RawPixelsPerViewPixel;

            // Get the current application view
            ApplicationView appView = ApplicationView.GetForCurrentView();

            // Try to resize the window to the available work area
            appView.TryResizeView(new Size(displayInfo.ScreenWidthInRawPixels / scale - 50, displayInfo.ScreenHeightInRawPixels / scale - 100));

            // Navigate to video editor page
            Frame appWindowContentFrame = new Frame();
            appWindowContentFrame.Navigate(typeof(VideoEditorPage));
            Window.Current.Content = appWindowContentFrame;
        }
    }
}
