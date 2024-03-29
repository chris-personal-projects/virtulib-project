﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using virtulib_project.Pages;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using virtulib_project.UserControls;
using virtulib_project.Models;
using System.Timers;
using System.Windows.Threading;
using MaterialDesignThemes.Wpf;

namespace virtulib_project.Pages
{
    /// <summary>
    /// Interaction logic for Browse.xaml
    /// </summary>
    public partial class ReturnPage : Page
    {
        
        private MainViewModel _mainViewModel = new MainViewModel();

        public ReturnPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            _mainViewModel = mainViewModel;
            DataContext = _mainViewModel;
        }

        private void Return1(object sender, MouseButtonEventArgs e)
        {
            Panel1.Children.Clear();
            Panel2.Margin = new Thickness(70, 175, 0, 0);
            Panel1.Visibility = Visibility.Hidden;

        }

        private void dropoff(object sender, MouseButtonEventArgs e)
        {
            DropOffDialog dropoffDialog = new DropOffDialog();
            _mainViewModel.SetDialog(dropoffDialog);
            Panel2.Children.Clear();
            Panel2.Visibility = Visibility.Hidden;

        }

        private void print(object sender, MouseButtonEventArgs e)
        {
            PrintLabelDialog printpopup = new PrintLabelDialog();
            _mainViewModel.SetDialog(printpopup);
            Panel2.Children.Clear();
            Panel2.Visibility = Visibility.Hidden;

        }

    }
}
