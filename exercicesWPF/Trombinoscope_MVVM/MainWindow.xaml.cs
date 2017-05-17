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
            DataContext = new VMMain();

		}
	}
}
