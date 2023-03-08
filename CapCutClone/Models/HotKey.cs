using System.Text;
using Windows.System;

namespace CapCutClone.Models
{
    public struct HotKey
    {
        public static HotKey None { get; } = new HotKey();

        public VirtualKey Key { get; set; }

        public VirtualKeyModifiers Modifiers { get; set; }

        public HotKey(VirtualKey key, VirtualKeyModifiers modifiers)
        {
            Key = key;
            Modifiers = modifiers;
        }

        public override string ToString()
        {
            if (Key == VirtualKey.None && Modifiers == VirtualKeyModifiers.None)
                return "< None >";

            var buffer = new StringBuilder();

            if (Modifiers.HasFlag(VirtualKeyModifiers.Control))
                buffer.Append("Ctrl + ");
            if (Modifiers.HasFlag(VirtualKeyModifiers.Shift))
                buffer.Append("Shift + ");
            if (Modifiers.HasFlag(VirtualKeyModifiers.Windows))
                buffer.Append("Win + ");

            buffer.Append(Key);

            return buffer.ToString();
        }
    }
}
