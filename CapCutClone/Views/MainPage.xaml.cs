using CapCutClone.ViewModels;
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
    }
}
