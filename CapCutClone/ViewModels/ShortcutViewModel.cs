using CapCutClone.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CapCutClone.ViewModels
{
    public partial class ShortcutViewModel : ObservableObject
    {

    }

    // Hotkeys
    public partial class ShortcutViewModel
    {
        #region TimeLine HotKeys

        private HotKey splitHotKey;
        public HotKey SplitHotKey
        {
            get => splitHotKey;
            set => SetProperty(ref splitHotKey, value);
        }

        private HotKey splitAllHotKey;
        public HotKey SplitAllHotKey
        {
            get => splitAllHotKey;
            set => SetProperty(ref splitAllHotKey, value);
        }

        private HotKey selectModeHotKey;
        public HotKey SelectModeHotkey
        {
            get { return selectModeHotKey; }
            set => SetProperty(ref selectModeHotKey, value);
        }

        private HotKey splitModeKey;
        public HotKey SplitModeHotKey
        {
            get => splitModeKey;
            set => SetProperty(ref splitModeKey, value);
        }

        private HotKey selectLeftwardHotKey;
        public HotKey SelectLeftwardHotKey
        {
            get => selectLeftwardHotKey;
            set => SetProperty(ref selectLeftwardHotKey, value);
        }

        private HotKey selectRightwardHotKey;
        public HotKey SelectRightwardHotKey
        {
            get => selectRightwardHotKey;
            set => SetProperty(ref selectRightwardHotKey, value);
        }

        private HotKey mainTrackMagnetHotKey;
        public HotKey MainTrackMagnetHotKey
        {
            get => mainTrackMagnetHotKey;
            set => SetProperty(ref mainTrackMagnetHotKey, value);
        }

        private HotKey autoSnappingHotKey;
        public HotKey AutoSnappingHotKey
        {
            get => autoSnappingHotKey;
            set => SetProperty(ref autoSnappingHotKey, value);
        }

        private HotKey linkageSwitchHotKey;
        public HotKey LinkageSwitchHotKey
        {
            get => linkageSwitchHotKey;
            set => SetProperty(ref linkageSwitchHotKey, value);
        }

        private HotKey previewAxisSwitchHotKey;
        public HotKey PreviewAxisSwitchHotKey
        {
            get => previewAxisSwitchHotKey;
            set => SetProperty(ref previewAxisSwitchHotKey, value);
        }

        private HotKey zoomInHotKey;
        public HotKey ZoomInHotKey
        {
            get => zoomInHotKey;
            set => SetProperty(ref zoomInHotKey, value);
        }

        private HotKey zoomOutHotKey;
        public HotKey ZoomOutHotKey
        {
            get => zoomOutHotKey;
            set => SetProperty(ref zoomOutHotKey, value);
        }

        private HotKey zoomInZoomOutHotKey;
        public HotKey ZoomInZoomOutHotKey
        {
            get => zoomInZoomOutHotKey;
            set => SetProperty(ref zoomInZoomOutHotKey, value);
        }

        private HotKey upDownHotKey;
        public HotKey UpDownHotKey
        {
            get => upDownHotKey;
            set => SetProperty(ref upDownHotKey, value);
        }

        private HotKey leftRightHotKey;
        public HotKey RightRightHotKey
        {
            get => leftRightHotKey;
            set => SetProperty(ref leftRightHotKey, value);
        }

        private HotKey activeDeactiveClipHotKey;
        public HotKey ActiveDeactiveClipHotKey
        {
            get => activeDeactiveClipHotKey;
            set => SetProperty(ref activeDeactiveClipHotKey, value);
        }

        private HotKey separateRestoreAudioHotKey;
        public HotKey SeparateRestoreAudioHotKey
        {
            get => separateRestoreAudioHotKey;
            set => SetProperty(ref separateRestoreAudioHotKey, value);
        }

        private HotKey mathCutHotKey;
        public HotKey MathCutHotKey
        {
            get => mathCutHotKey;
            set => SetProperty(ref mathCutHotKey, value);
        }

        private HotKey previousFrameHotKey;
        public HotKey PreviousFrameHotKey
        {
            get => previousFrameHotKey;
            set => SetProperty(ref previousFrameHotKey, value);
        }

        private HotKey nextFrameHotKey;
        public HotKey NextFrameHotKey
        {
            get => nextFrameHotKey;
            set => SetProperty(ref nextFrameHotKey, value);
        }

        private HotKey locateToFirstFrameHotKey;
        public HotKey LocateToFirstFrameHotKey
        {
            get => locateToFirstFrameHotKey;
            set => SetProperty(ref locateToFirstFrameHotKey, value);
        }

        private HotKey locateToLastFrameHotKey;
        public HotKey LocateToLastFrameHotKey
        {
            get => locateToLastFrameHotKey;
            set => SetProperty(ref locateToLastFrameHotKey, value);
        }

        private HotKey lastCutPointHotKey;
        public HotKey LastCutPointHotKey
        {
            get => lastCutPointHotKey;
            set => SetProperty(ref lastCutPointHotKey, value);
        }

        private HotKey nextCutPointHotKey;
        public HotKey NextCutPointHotKey 
        {
            get => nextCutPointHotKey;
            set => SetProperty(ref nextCutPointHotKey, value); 
        }

        private HotKey inPointHotKey;
        public HotKey InPointHotKey
        {
            get => inPointHotKey;
            set => SetProperty(ref inPointHotKey, value);
        }

        private HotKey outPointHotKey;
        public HotKey OutPointHotKey
        {
            get => outPointHotKey;
            set => SetProperty(ref outPointHotKey, value);
        }

        private HotKey selectAnAreaByClipHotKey;
        public HotKey SelectAnAreaByClipHotKey
        {
            get => selectAnAreaByClipHotKey;
            set => SetProperty(ref selectAnAreaByClipHotKey, value);
        }

        private HotKey unselectAreaHotKey;
        public HotKey UnselectAnAreaHotKey
        {
            get => unselectAreaHotKey;
            set => SetProperty(ref unselectAreaHotKey, value);
        }

        private HotKey groupHotKey;
        public HotKey GroupHotKey
        {
            get => groupHotKey;
            set => SetProperty(ref groupHotKey, value);
        }

        private HotKey ungroupHotKey;
        public HotKey UngroupHotKey
        {
            get => ungroupHotKey;
            set => SetProperty(ref ungroupHotKey, value);
        }

        private HotKey showSpeedPanelHotKey;
        public HotKey ShowSpeedPanelHotKey
        {
            get => showSpeedPanelHotKey;
            set => SetProperty(ref showSpeedPanelHotKey, value);
        }

        private HotKey curveSpeedHotKey;
        public HotKey CurveSpeedHotKey
        {
            get => curveSpeedHotKey;
            set => SetProperty(ref curveSpeedHotKey, value);
        }

        private HotKey createCompoundClipHotKey;
        public HotKey CreateCompoundClipHotKey
        {
            get => createCompoundClipHotKey;
            set => SetProperty(ref createCompoundClipHotKey, value);
        }

        private HotKey unlockCompoundClipDraftHotKey;
        public HotKey UnlockCompoundClipDraftHotKey
        {
            get => unlockCompoundClipDraftHotKey;
            set => SetProperty(ref unlockCompoundClipDraftHotKey, value);
        }

        private HotKey volumePlusHotKey;
        public HotKey VolumePlusHotKey
        {
            get => volumePlusHotKey;
            set => SetProperty(ref volumePlusHotKey, value);
        }

        private HotKey volumeMinusHotKey;
        public HotKey VolumeMinusHotKey
        {
            get => volumeMinusHotKey;
            set => SetProperty(ref volumeMinusHotKey, value);
        }

        private HotKey inHotKey;
        public HotKey InHotKey
        {
            get => inHotKey;
            set => SetProperty(ref inHotKey, value);
        }

        #endregion TimeLine HotKeys

        #region Player HotKeys

        private HotKey playPauseHotKey;
        public HotKey PlayPauseHotKey
        {
            get => playPauseHotKey;
            set => SetProperty(ref playPauseHotKey, value);
        }

        private HotKey enterExitFullScreenHotKey;
        public HotKey EnterExitFullScreenHotKey
        {
            get => enterExitFullScreenHotKey;
            set => SetProperty(ref enterExitFullScreenHotKey, value);
        }

        private HotKey cancelPlayerAlignmentHotKey;
        public HotKey CancelPlayerAlignmentHotKey
        {
            get => cancelPlayerAlignmentHotKey;
            set => SetProperty(ref cancelPlayerAlignmentHotKey, value);
        }

        #endregion Player HotKeys

        #region Basic HotKeys

        private HotKey copyHotKey;
        public HotKey CopyHotKey
        {
            get => copyHotKey;
            set => SetProperty(ref copyHotKey, value);
        }

        private HotKey cutHotKey;
        public HotKey CutHotKey
        {
            get => cutHotKey;
            set => SetProperty(ref cutHotKey, value);
        }

        private HotKey pasteHotKey;
        public HotKey PasteHotKey
        {
            get => pasteHotKey;
            set => SetProperty(ref pasteHotKey, value);
        }

        private HotKey deleteHotKey;
        public HotKey DeleteHotKey
        {
            get => deleteHotKey;
            set => SetProperty(ref deleteHotKey, value);
        }

        private HotKey undoHotKey;
        public HotKey UndoHotKey
        {
            get => undoHotKey;
            set => SetProperty(ref undoHotKey, value);
        }

        private HotKey redoHotKey;
        public HotKey RedoHotKey
        {
            get => redoHotKey;
            set => SetProperty(ref redoHotKey, value);
        }

        private HotKey importMediaHotKey;
        public HotKey ImportMediaHotKey
        {
            get => importMediaHotKey;
            set => SetProperty(ref importMediaHotKey, value);
        }

        private HotKey exportStillFrameHotKey;
        public HotKey ExportStillFrameHotKey
        {
            get => exportStillFrameHotKey;
            set => SetProperty(ref exportStillFrameHotKey, value);
        }

        private HotKey exportHotKey;
        public HotKey ExportHotKey
        {
            get => exportHotKey;
            set => SetProperty(ref exportHotKey, value);
        }

        private HotKey newProjectHotKey;
        public HotKey NewProjectHotKey
        {
            get => newProjectHotKey;
            set => SetProperty(ref newProjectHotKey, value);
        }

        private HotKey switchMaterialPanelHotKey;
        public HotKey SwitchMaterialPanelHotKey
        {
            get => switchMaterialPanelHotKey;
            set => SetProperty(ref switchMaterialPanelHotKey, value);
        }

        private HotKey backToEditHotKey;
        public HotKey BackToEditHotKey
        {
            get => backToEditHotKey;
            set => SetProperty(ref backToEditHotKey, value);
        }

        private HotKey quitHotKey;
        public HotKey QuitHotKey
        {
            get => quitHotKey;
            set => SetProperty(ref quitHotKey, value);
        }

        #endregion Basic HotKeys

        #region Other HotKeys

        private HotKey splitCaptionsHotKey;
        public HotKey SplitCaptionsHotKey
        {
            get => splitCaptionsHotKey;
            set => SetProperty(ref splitCaptionsHotKey, value);
        }

        private HotKey captionsLineWrapHotKey;
        public HotKey CaptionsLineWrapHotKey
        {
            get => captionsLineWrapHotKey;
            set => SetProperty(ref captionsLineWrapHotKey, value);
        }

        #endregion Other HotKeys
    }
}
