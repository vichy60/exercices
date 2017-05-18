using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace Trombinoscope
{
	/// <summary>
	/// Logique d'interaction pour UCTrombi.xaml
	/// </summary>
	public partial class UCTrombi : UserControl
	{
		public UCTrombi()
		{
			InitializeComponent();

			// Récupère le photos des employés
			List<Employe> employes = DAL.GeEmployes();

			// Les affiche dans la ListBox
			/*foreach (var p in photos)
			{
				var img = new Image();
				img.Source = p;
				img.Width = 200;
				lbPhotos.Items.Add(img);
			}*/
			DataContext = employes;
		}
	}
}