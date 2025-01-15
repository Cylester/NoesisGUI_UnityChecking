#if UNITY_5_3_OR_NEWER
#define Noesis
using Noesis;
#else
using System.Windows.Controls;
#endif

using GUICheck.Assets._Project.NoesisGUI.Core;
using System.Windows.Input;

namespace GUICheck.Assets._Project.NoesisGUI.MVVM.ViewModels
{
    public class HomeViewModel : NotifyPropertyChanged
    {
        private SettingsViewModel settingsViewModel;

        public SettingsViewModel SettingsViewModel
        {
            get { return settingsViewModel; }
            set
            {
                if (settingsViewModel != value)
                {
                    settingsViewModel = value;
                    OnPropertyChanged(nameof(SettingsViewModel));
                }
            }
        }

        private AboutViewModel aboutViewModel;

        public AboutViewModel AboutViewModel
        {
            get { return aboutViewModel; }
            set
            {
                if (aboutViewModel != value)
                {
                    aboutViewModel = value;
                    OnPropertyChanged(nameof(AboutViewModel));
                }
            }
        }

        public ICommand ButtonSettingsCommand { get; }
        public ICommand ButtonAboutCommand { get; }
        public ICommand ButtonStartGameCommand { get; }

        public HomeViewModel()
        {
            ButtonSettingsCommand = new DelegateCommand(ExecuteButtonSettingsCommand);
            ButtonStartGameCommand = new DelegateCommand(ExecuteButtonStartGameCommand);
            ButtonAboutCommand = new DelegateCommand(ExecuteButtonAboutCommand);
        }

        private void ExecuteButtonSettingsCommand(object args)
        {
            //ChangeAdditionalView(new SettingsView());
            SettingsViewModel = SettingsViewModel == null ? new SettingsViewModel() : null;
            AboutViewModel = null;
        }

        private void ExecuteButtonAboutCommand(object args)
        {
            //ChangeAdditionalView(new AboutView());
            AboutViewModel = AboutViewModel == null ? new AboutViewModel() : null;
            SettingsViewModel = null;
        }

        private void ExecuteButtonStartGameCommand(object args)
        {

        }
    }
}
