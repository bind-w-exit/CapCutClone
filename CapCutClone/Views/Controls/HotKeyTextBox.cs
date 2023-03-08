using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using CapCutClone.Models;
using Windows.System;
using Windows.UI.Core;

namespace CapCutClone.Views.Controls
{
    public class HotKeyTextBox : TextBox
    {
        public HotKey HotKey
        {
            get => (HotKey)GetValue(HotKeyProperty);
            set => SetValue(HotKeyProperty, value);
        }

        public static readonly DependencyProperty HotKeyProperty = DependencyProperty.Register(
            nameof(HotKey),
            typeof(HotKey),
            typeof(HotKeyTextBox),
            new PropertyMetadata(
            default(HotKey),
            HotKeyChanged
            ));

        private static void HotKeyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is HotKeyTextBox control)
            {
                control.Text = control.HotKey.ToString();
            }
        }

        public HotKeyTextBox()
        {
            IsReadOnly = true;
            //IsReadOnlyCaretVisible = false;
            //IsUndoEnabled = false;

            //if (ContextMenu is not null)
            //    ContextMenu.Visibility = Visibility.Collapsed;

            Text = HotKey.ToString();
        }

        private static bool HasKeyChar(VirtualKey key)
        {
            switch (key)
            {
                case VirtualKey.A:
                case VirtualKey.B:
                case VirtualKey.C:
                case VirtualKey.D:
                case VirtualKey.E:
                case VirtualKey.F:
                case VirtualKey.G:
                case VirtualKey.H:
                case VirtualKey.I:
                case VirtualKey.J:
                case VirtualKey.K:
                case VirtualKey.L:
                case VirtualKey.M:
                case VirtualKey.N:
                case VirtualKey.O:
                case VirtualKey.P:
                case VirtualKey.Q:
                case VirtualKey.R:
                case VirtualKey.S:
                case VirtualKey.T:
                case VirtualKey.U:
                case VirtualKey.V:
                case VirtualKey.W:
                case VirtualKey.X:
                case VirtualKey.Y:
                case VirtualKey.Z:
                case VirtualKey.Number0:
                case VirtualKey.Number1:
                case VirtualKey.Number2:
                case VirtualKey.Number3:
                case VirtualKey.Number4:
                case VirtualKey.Number5:
                case VirtualKey.Number6:
                case VirtualKey.Number7:
                case VirtualKey.Number8:
                case VirtualKey.Number9:
                case VirtualKey.NumberPad0:
                case VirtualKey.NumberPad1:
                case VirtualKey.NumberPad2:
                case VirtualKey.NumberPad3:
                case VirtualKey.NumberPad4:
                case VirtualKey.NumberPad5:
                case VirtualKey.NumberPad6:
                case VirtualKey.NumberPad7:
                case VirtualKey.NumberPad8:
                case VirtualKey.NumberPad9:
                //case VirtualKey.Question:
                //case VirtualKey.Quotes:
                case VirtualKey.Add:
                case VirtualKey.Subtract:
                case VirtualKey.Multiply:
                case VirtualKey.Divide:
                //case VirtualKey.LeftBracket:
                //case VirtualKey.RightBracket:
                //case VirtualKey.Minus:
                //case VirtualKey.Comma:
                //case VirtualKey.Period:
                //case VirtualKey.Semicolon:
                //case VirtualKey.Slash:
                //case VirtualKey.BackSlash:
                //case VirtualKey.GraveAccent:
                case VirtualKey.Space:
                //case VirtualKey.Equals:
                    return true;
                default:
                    return false;
            }
        }


        protected override void OnKeyDown(KeyRoutedEventArgs e)
        {
            e.Handled = true;

            // Get modifiers and key data
            var modifiers = VirtualKeyModifiers.None;
            if (Window.Current.CoreWindow.GetKeyState(VirtualKey.Menu).HasFlag(CoreVirtualKeyStates.Down))
            {
                modifiers |= VirtualKeyModifiers.Menu;
            }
            if (Window.Current.CoreWindow.GetKeyState(VirtualKey.Control).HasFlag(CoreVirtualKeyStates.Down))
            {
                modifiers |= VirtualKeyModifiers.Control;
            }
            if (Window.Current.CoreWindow.GetKeyState(VirtualKey.Shift).HasFlag(CoreVirtualKeyStates.Down))
            {
                modifiers |= VirtualKeyModifiers.Shift;
            }
            if (Window.Current.CoreWindow.GetKeyState(VirtualKey.LeftWindows).HasFlag(CoreVirtualKeyStates.Down) ||
                Window.Current.CoreWindow.GetKeyState(VirtualKey.RightWindows).HasFlag(CoreVirtualKeyStates.Down))
            {
                modifiers |= VirtualKeyModifiers.Windows;
            }

            var key = e.Key;

            // If nothing was pressed - return
            if (key == VirtualKey.None)
                return;

            // If Alt is used as modifier - the key needs to be extracted from SystemKey
            if (modifiers.HasFlag(VirtualKeyModifiers.Menu))
                key = e.OriginalKey;

            // If Delete/Backspace/Escape is pressed without modifiers - clear current value and return
            if ((key == VirtualKey.Delete || key == VirtualKey.Back || key == VirtualKey.Escape) && modifiers == VirtualKeyModifiers.None)
            {
                HotKey = HotKey.None;
                return;
            }

            // If the only key pressed is one of the modifier keys - return
            if (IsModifierKey(key))
                return;

            // If Enter/Space/Tab is pressed without modifiers - return
            if ((key == VirtualKey.Enter || key == VirtualKey.Space || key == VirtualKey.Tab) && modifiers == VirtualKeyModifiers.None)
                return;

            // If key has a character and pressed without modifiers or only with Shift - return
            if (HasKeyChar(key) && (modifiers == VirtualKeyModifiers.None || modifiers == VirtualKeyModifiers.Shift))
                return;

            // Set value
            HotKey = new HotKey(key, modifiers);
        }

        private bool IsModifierKey(VirtualKey key)
        {
            return key == VirtualKey.LeftControl || key == VirtualKey.RightControl ||
                   key == VirtualKey.LeftMenu || key == VirtualKey.RightMenu ||
                   key == VirtualKey.LeftShift || key == VirtualKey.RightShift ||
                   key == VirtualKey.LeftWindows || key == VirtualKey.RightWindows ||
                   key == VirtualKey.Application || key == VirtualKey.Clear;
        }
    }
}
