#if UNITY_5_3_OR_NEWER
#define Noesis
using Noesis;
#else
using System;
using System.Windows.Controls;
#endif

using GUICheck.Assets._Project.NoesisGUI.Core;

namespace GUICheck.Assets._Project.NoesisGUI.MVVM.ViewModels
{
    public class SettingsViewModel : NotifyPropertyChanged
    {
        
    }
}