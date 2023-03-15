using CapCutClone.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CapCutClone.Views.Controls
{
    public sealed partial class TextBlockWithHotKey : UserControl
    {
        public TextBlockWithHotKey()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register("LabelText", typeof(string), typeof(TextBlockWithHotKey), new PropertyMetadata(string.Empty));

        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        public static readonly DependencyProperty HotKeyProperty =
            DependencyProperty.Register("HotKey", typeof(HotKey), typeof(TextBlockWithHotKey), new PropertyMetadata(HotKey.None));

        public HotKey HotKey
        {
            get { return (HotKey)GetValue(HotKeyProperty); }
            set { SetValue(HotKeyProperty, value); }
        }
    }
}
