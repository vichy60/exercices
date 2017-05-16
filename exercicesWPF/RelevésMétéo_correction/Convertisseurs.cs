using System;
using System.Diagnostics;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media;
using System.Windows;

namespace RelevésMétéo
{
	// Convertisseur fictif pour pouvoir déboguer les binding
	public class DebugDummyConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			Debugger.Break();
			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			Debugger.Break();
			return value;
		}
	}

	// Convertisseur de booléen vers visibilité
	public class BoolToVisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			bool d = (bool)value;
			return (bool)value ? Visibility.Visible : Visibility.Hidden;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}

	// Convertisseur de Double en Brush avec seuil
	public class DoubleToColorBrushConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			double v = (double)value;
			double p = (double)parameter;
			Color c = (v < p ? Colors.LightYellow : Colors.White);
			return new SolidColorBrush(c);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
