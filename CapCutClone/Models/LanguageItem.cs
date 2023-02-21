namespace CapCutClone.Models
{
    public class LanguageItem
    {
        public LanguageItem(string tag, string displayName)
        {
            Tag = tag;
            DisplayName = displayName;
        }

        public string DisplayName { get; set; }
        public string Tag { get; set; }
    }
}