#if NOESIS
using Noesis;
using System;
#else
using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using NoesisGUICSharp_Testing.Core;
using NoesisGUICSharp_Testing.MVVM.Views;
using NoesisGUICSharp_Testing.Services;
using NoesisGUICSharp_Testing.Views;

#endif

namespace NoesisGUICSharp_Testing.ModelViews
{
    /// <summary>
    /// Logic for application ViewModel!
    /// </summary>
    public partial class ViewModel : NotifyProperty, IModelView
    {
        private readonly INavigationService _navigationService;

        public ViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand NavigateToGameViewCommand => new DelegateCommand(NavigateToGameView);

        private void NavigateToGameView(object args)
        {
            _navigationService.NavigateTo("Game");
        }
    }
}