using CommunityToolkit.Mvvm.ComponentModel;

namespace CapCutClone.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public string ProjectsCount { get; set; } = "(10)";
        public MainViewModel()
        {
            
        }
    }
}
