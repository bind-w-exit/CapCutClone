using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CapCutClone.Views
{
    public sealed partial class VideoEditorPage : Page
    {
        public VideoEditorPage()
        {
            InitializeComponent();
            Window.Current.SetTitleBar(AppTitleBar);
        }
    }
}
