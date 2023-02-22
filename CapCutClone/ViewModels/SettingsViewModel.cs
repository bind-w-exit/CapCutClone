using CapCutClone.Enums;
using CapCutClone.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace CapCutClone.ViewModels
{
    public class SettingsViewModel : ObservableObject 
    {
        private readonly SettingsService _settingsService;

        public SettingsViewModel(SettingsService settingsService) 
        {
            _settingsService = settingsService;
            LoadFromSetting();
            SelectProjectSavePathCommand = new RelayCommand(SelectProjectSavePath);
            DeleteProjectCacheCommand = new RelayCommand(DeleteProjectCache);
            IncrementImageDuration = new RelayCommand(() => { ImageDuration++; });
            DecrementImageDuration = new RelayCommand(() => 
            {
                if (ImageDuration != 0)
                    ImageDuration--;     
            });
            SelectProxySavePathCommand = new RelayCommand(SelectProxySavePath);
            DeleteProxyCacheCommand = new RelayCommand(DeleteProxyCache);
        }

        private string projectSavePath;
        public string ProjectSavePath 
        {
            get => projectSavePath;
            set => SetProperty(ref projectSavePath, value);
        }

        private bool cacheManegment;
        public bool CacheManegment 
        {
            get => cacheManegment;
            set => SetProperty(ref cacheManegment, value);
        }

        public List<int> AutoDeleteCachePeriods 
        {
            get { return Enum.GetValues(typeof(TimePeriod)).Cast<int>().ToList(); }
        }

        private int selectedAutoDeleteCachePeriod;
        public int SelectedAutoDeleteCachePeriod 
        {
            get => selectedAutoDeleteCachePeriod;
            set => SetProperty(ref selectedAutoDeleteCachePeriod, value);
        }       

        //TODO: Get CacheSize
        public string CacheSize { get; } = "30.05 MB";

        private uint imageDuration;
        public uint ImageDuration 
        {
            get => imageDuration;
            set 
            {
                if (value > 1800)
                    value = 1800;
                SetProperty(ref imageDuration, value);
            }
        }

        public List<string> ImageDurationUnits { get; } = Enum.GetNames(typeof(DurationUnit)).ToList();

        private string selectedImageDurationUnit;
        public string SelectedImageDurationUnit 
        {
            get => selectedImageDurationUnit;
            set => SetProperty(ref selectedImageDurationUnit, value);
        }

        private bool isFreeLayerTurnedOn;
        public bool IsFreeLayerTurnedOn 
        {
            get => isFreeLayerTurnedOn;
            set => SetProperty(ref isFreeLayerTurnedOn, value);
        }

        public List<int> FrameRates 
        {
            get { return Enum.GetValues(typeof(FrameRate)).Cast<int>().ToList(); }
        }

        private int selectedFrameRate;
        public int SelectedFrameRate 
        {
            get => selectedFrameRate;
            set => SetProperty(ref selectedFrameRate, value);
        }

        public List<string> TimeCodes { get; } = new List<string>() { "HH:MM:SS+frame", "HH:MM:SS:FF", };

        private string selectedTimeCode;
        public string SelectedTimeCode 
        {
            get => selectedTimeCode;
            set => SetProperty(ref selectedTimeCode, value);
        }

        private bool іsHardwareEncodingEnabled;
        public bool IsHardwareEncodingEnabled
        {
            get => іsHardwareEncodingEnabled;
            set => SetProperty(ref іsHardwareEncodingEnabled, value);
        }

        private bool іsHardwareDecodingEnabled;
        public bool IsHardwareDecodingEnabled
        {
            get => іsHardwareDecodingEnabled;
            set => SetProperty(ref іsHardwareDecodingEnabled, value);
        }

        private bool isRenderWithGpuEnabled;
        public bool IsRenderWithGpuEnabled 
        {
            get => isRenderWithGpuEnabled;
            set => SetProperty(ref isRenderWithGpuEnabled, value);
        }

        private bool isProxyEnabled;
        public bool IsProxyEnabled 
        {
            get => isProxyEnabled;
            set => SetProperty(ref isProxyEnabled, value);
        }

        private string proxySavePath;
        public string ProxySavePath 
        {
            get => proxySavePath;
            set => SetProperty(ref proxySavePath, value);
        }

        //TODO: Get CacheSize
        public string ProxySize { get; } = "20.25MB";

        public ICommand SelectProjectSavePathCommand { get; }

        public ICommand DeleteProjectCacheCommand { get; }

        public ICommand IncrementImageDuration { get; }

        public ICommand DecrementImageDuration { get; }

        public ICommand SelectProxySavePathCommand { get; }

        public ICommand DeleteProxyCacheCommand { get; }


        private void SelectProjectSavePath() 
        {
            //TODO: Write implementation for SelectProjectSavePath
        }

        private void DeleteProjectCache() 
        {
            //TODO: Write implementation for DeleteCache
        }

        private void SelectProxySavePath() 
        {
            //TODO: Write implementation for SelectProxySavePath
        }

        private void DeleteProxyCache() 
        {
            //TODO: Write implementation for DeleteProxyCache
        }

        private void LoadFromSetting() 
        {
            ProjectSavePath = _settingsService.ProjectSavePath;
            CacheManegment = _settingsService.CacheManegment;
            SelectedAutoDeleteCachePeriod = (int)_settingsService.AutoDeleteCachePeriod;
            ImageDuration = _settingsService.ImageDuration;
            SelectedImageDurationUnit = _settingsService.ImageDurationUnit.ToString();
            IsFreeLayerTurnedOn = _settingsService.IsFreeLayerTurnedOn;
            SelectedFrameRate = (int)_settingsService.FrameRate;
            SelectedTimeCode = _settingsService.TimeCode;
            IsHardwareEncodingEnabled = _settingsService.IsHardwareEncodingEnabled;
            IsHardwareDecodingEnabled = _settingsService.IsHardwareDecodingEnabled;
            IsRenderWithGpuEnabled = _settingsService.IsRenderWithGpuEnabled;
            IsProxyEnabled = _settingsService.IsProxyEnabled;
            ProxySavePath = _settingsService.ProxySavePath;
        }
    }
}
