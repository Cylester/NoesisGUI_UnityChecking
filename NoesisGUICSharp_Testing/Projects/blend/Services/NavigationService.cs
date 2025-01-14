using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using NoesisGUICSharp_Testing.MVVM.Views;
using NoesisGUICSharp_Testing.Views;

namespace NoesisGUICSharp_Testing.Services
{
    public class NavigationService : INavigationService
    {
        private readonly Dictionary<string, Type> _pages;
        private readonly Frame _frame;

        public NavigationService(Frame frame)
        {
            _frame = frame;
            _pages = new Dictionary<string, Type>
                {
                    { "Menu", typeof(HomeView) },
                    { "Game", typeof(GamePlayView) }
                };
        }

        public void NavigateTo(string pageKey)
        {
            if (_pages.ContainsKey(pageKey))
            {
                _frame.Navigate(Activator.CreateInstance(_pages[pageKey]));
            }
        }
    }

}
