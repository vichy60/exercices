using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Trombinoscope2
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private UCTrombi _ucTrombi;
		private UCEmployes _ucEmployes;

		public MainWindow()
		{
			InitializeComponent();

			//UserControl uc2 = new UserControl2();

			menuTrombi.Click += MenuTrombi_Click;
			menuEmployes.Click += MenuEmployes_Click;
		}
		private void MenuTrombi_Click(object sender, RoutedEventArgs e)
		{
			if (_ucTrombi == null) _ucTrombi = new UCTrombi();

			contentCtrl.Content = _ucTrombi;
		}

		private void MenuEmployes_Click(object sender, RoutedEventArgs e)
		{
			if (_ucEmployes == null) _ucEmployes = new UCEmployes();

			contentCtrl.Content = _ucEmployes;
		}
	}
}
