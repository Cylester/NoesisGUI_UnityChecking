#if NOESIS
using Noesis;
using NoesisApp;
#else
using System.Collections.Generic;
using System;
using System.Windows;
using System.Windows.Controls;
using NoesisGUICSharp_Testing.ModelViews;
using NoesisGUICSharp_Testing.MVVM.Views;
using NoesisGUICSharp_Testing.Services;

#endif

namespace NoesisGUICSharp_Testing.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NavigationService navigationService;

        public MainWindow()
        {
            InitializeComponent();

            //navigationService = new NavigationService(MainFrame);
            DataContext = new ViewModel(navigationService);

            //MainFrame.Navigate(new HomeView());
        }

#if NOESIS
        private void InitializeComponent()
        {
            GUI.LoadComponent(this, "MainWindow.xaml");
        }
#endif
    }
}