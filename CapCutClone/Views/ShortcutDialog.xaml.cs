using CapCutClone.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using Windows.UI.Xaml.Controls;

namespace CapCutClone.Views
{
    public sealed partial class ShortcutDialog : ContentDialog
    {
        public ShortcutDialog()
        {
            InitializeComponent();
            DataContext = Ioc.Default.GetRequiredService<ShortcutViewModel>();
        }

        public ShortcutViewModel ViewModel => (ShortcutViewModel)DataContext;

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }
    }
}
