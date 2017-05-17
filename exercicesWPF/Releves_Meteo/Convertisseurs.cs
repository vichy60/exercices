using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Releves_Meteo
{
    public class VueToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string vue = value.ToString();
            string nomGrid = parameter.ToString();

            Visibility res = Visibility.Visible;

            if(vue == "Vignettes")
            {
                if (nomGrid != "gdStatsVignette")
                    res = Visibility.Hidden;
            }
            else
            {
                if (nomGrid == "gdStatsVignette")
                    res = Visibility.Hidden;
            }

            return res;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    // Convertisseur de Decimal en Brush avec seuil
    public class PrécipitationMinToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double d = (double)value;
            double seuil = (double)parameter;
            Color c = (d <= seuil ? Colors.LightYellow : Colors.White);
            return new SolidColorBrush(c);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class VueToTemplateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //string res = null;

            //if ((string)value == "Vignettes")
            //    res = "Template_vignette";
            //else
            //    res = "Template_groupe";

            //return res;

            return (string)value == "Vignettes" ? "Template_vignette" : "Template_groupe";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

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
}
