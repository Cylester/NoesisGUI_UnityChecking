using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using NoesisGUICSharp_Testing.Core;
using NoesisGUICSharp_Testing.MVVM.Views;
using NoesisGUICSharp_Testing.Services;
using NoesisGUICSharp_Testing.Views;

namespace NoesisGUICSharp_Testing.ModelViews
{
    public class HomeModelView : NotifyProperty, IModelView
    {
        public ICommand ButtonSettingsCommand { get; }
        public ICommand ButtonAboutCommand { get; }
        public ICommand ButtonStartGameCommand { get; }

        private UserControl currentView { get; set; }
        public UserControl CurrentView
        {
            get { return currentView; }
            set
            {
                if (currentView != value)
                {
                    currentView = value;
                    OnPropertyChanged(nameof(currentView));
                }
            }
        }
        public HomeModelView()
        {
            ButtonSettingsCommand = new DelegateCommand(ExecuteButtonSettingsCommand);
            ButtonStartGameCommand = new DelegateCommand(ExecuteButtonStartGameCommand);
            ButtonAboutCommand = new DelegateCommand(ExecuteButtonAboutCommand);
        }

        private void ExecuteButtonSettingsCommand(object args)
        {
            ChangeAdditionalView(new SettingsView());
        }

        private void ExecuteButtonAboutCommand(object args)
        {
            ChangeAdditionalView(new AboutView());
        }

        private void ExecuteButtonStartGameCommand(object args)
        {
            
        }

        private void ChangeAdditionalView(UserControl view)
        {
            if (CurrentView == null || CurrentView.GetType() != view.GetType())
                CurrentView = view;
            else
                CurrentView = null;
        }
    }
}
