﻿using CapCutClone.Enums;
using CapCutClone.Models;
using System;
using Windows.Storage;

namespace CapCutClone.Services
{
    public class SettingsService
    {
        private readonly ApplicationDataContainer _localSettings;

        public SettingsService()
        {
            _localSettings = ApplicationData.Current.LocalSettings;
            Load();
        }

        public string ProjectSavePath { get; set; }

        /// <summary>
        /// Has two state:
        /// Don't delete and Auto delete
        /// </summary>
        public bool CacheManegment { get; set; }

        public TimePeriod AutoDeleteCachePeriod { get; set; }

        public uint ImageDuration { get; set; }

        public DurationUnit ImageDurationUnit { get; set; }

        public bool IsFreeLayerTurnedOn { get; set; }

        public FrameRate FrameRate { get; set; }

        public string TimeCode { get; set; }

        public bool IsHardwareEncodingEnabled { get; set; } = true;

        public bool IsHardwareDecodingEnabled { get; set; } = true;

        public bool IsRenderWithGpuEnabled { get; set; } = true;

        public bool IsProxyEnabled { get; set; } = true;

        public string ProxySavePath { get; set; } = "";

        public LanguageItem SelectedLanguage { get; set; }

        public event EventHandler SettingsLoadedEvent;

        public event EventHandler SettingsSavedEvent;

        public void Load()
        {
            ProjectSavePath = GetValueOrDefault(nameof(ProjectSavePath), "Path////");
            CacheManegment = GetValueOrDefault(nameof(CacheManegment), false);
            AutoDeleteCachePeriod = GetValueOrDefault(nameof(AutoDeleteCachePeriod), TimePeriod.ThirtyDays);
            ImageDuration = GetValueOrDefault(nameof(ImageDuration), (uint)180);
            ImageDurationUnit = GetValueOrDefault(nameof(ImageDurationUnit), DurationUnit.Frame);
            IsFreeLayerTurnedOn = GetValueOrDefault(nameof(IsFreeLayerTurnedOn), true);
            FrameRate = GetValueOrDefault(nameof(FrameRate), FrameRate._60FPS);
            TimeCode = GetValueOrDefault(nameof(TimeCode), "HH:MM:SS+frame");
            IsHardwareEncodingEnabled = GetValueOrDefault(nameof(IsHardwareEncodingEnabled), true);
            IsHardwareDecodingEnabled = GetValueOrDefault(nameof(IsHardwareDecodingEnabled), true);
            IsRenderWithGpuEnabled = GetValueOrDefault(nameof(IsRenderWithGpuEnabled), true);
            IsProxyEnabled = GetValueOrDefault(nameof(IsProxyEnabled), true);
            ProxySavePath = GetValueOrDefault(nameof(ProxySavePath), "Path////");
            SelectedLanguage = GetValueOrDefault(nameof(SelectedLanguage), new LanguageItem("en-US", "English"));

            SettingsLoadedEvent?.Invoke(this, EventArgs.Empty);
        }

        public void Save()
        {
            _localSettings.Values[nameof(ProjectSavePath)] = ProjectSavePath;
            _localSettings.Values[nameof(CacheManegment)] = CacheManegment;
            _localSettings.Values[nameof(AutoDeleteCachePeriod)] = AutoDeleteCachePeriod;
            _localSettings.Values[nameof(ImageDuration)] = ImageDuration;
            _localSettings.Values[nameof(IsFreeLayerTurnedOn)] = IsFreeLayerTurnedOn;
            _localSettings.Values[nameof(FrameRate)] = FrameRate;
            _localSettings.Values[nameof(TimeCode)] = TimeCode;
            _localSettings.Values[nameof(IsHardwareEncodingEnabled)] = IsHardwareEncodingEnabled;
            _localSettings.Values[nameof(IsHardwareDecodingEnabled)] = IsHardwareDecodingEnabled;
            _localSettings.Values[nameof(IsRenderWithGpuEnabled)] = IsRenderWithGpuEnabled;
            _localSettings.Values[nameof(IsProxyEnabled)] = IsProxyEnabled;
            _localSettings.Values[nameof(ProxySavePath)] = ProxySavePath;
            _localSettings.Values[nameof(ProjectSavePath)] = ProjectSavePath;
            _localSettings.Values[nameof(SelectedLanguage)] = SelectedLanguage;

            SettingsSavedEvent?.Invoke(this, EventArgs.Empty);
        }

        private T GetValueOrDefault<T>(string key, T defaultValue)
        {
            if (_localSettings.Values.ContainsKey(key))
            {
                return (T)_localSettings.Values[key];
            }

            return defaultValue;
        }
    }
}