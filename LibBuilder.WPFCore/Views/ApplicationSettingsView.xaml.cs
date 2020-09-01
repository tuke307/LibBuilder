﻿// project=LibBuilder.WPFCore, file=ApplicationSettingsView.xaml.cs, creation=2020:8:24
// Copyright (c) 2020 Timeline Financials GmbH & Co. KG. All rights reserved.
namespace LibBuilder.WPFCore.Views
{
    using LibBuilder.WPFCore.Region;
    using LibBuilder.WPFCore.ViewModels;
    using MvvmCross.Platforms.Wpf.Views;

    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    [MvxWpfPresenter("MainWindowRegion", mvxViewPosition.NewOrExsist)]
    public partial class ApplicationSettingsView : MvxWpfView<ApplicationSettingsViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationSettingsView" />
        /// class.
        /// </summary>
        public ApplicationSettingsView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ApplicationSettings.Default.Save();
        }
    }
}