﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CapCutClone.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            SelectedViewType = ViewTypes[0];
            OpenSettingsDialogCommand = new RelayCommand(OpenSettingsDialog);
            OpenVideoEditorWindowCommand = new RelayCommand(OpenVideoEditorWindow);
        }

        public string ProjectsCount { get; set; } = "(0)";

        public ObservableCollection<string> ViewTypes { get; } = new ObservableCollection<string>() { "Grid", "List" };

        public string SelectedViewType { get; set; }

        public ICommand OpenSettingsDialogCommand { get; }

        public ICommand OpenVideoEditorWindowCommand { get; }

        private void OpenSettingsDialog()
        {

        }

        private void OpenVideoEditorWindow()
        {

        }
    }
}
