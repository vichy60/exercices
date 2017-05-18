using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Saisie_de_taches
{
    public class ConvModeEditLectureSeule : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //if (ModesEdition.Consultation.CompareTo(value) == 0)
            //{ return false; }
            //else return true;

            return ModesEdition.Consultation.CompareTo(value) == 0 ? true :false  ;  //opérateur ternaire
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ConvModeEditActivation : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ModesEdition.Consultation.CompareTo(value) == 0 ? false : true;  //opérateur ternaire
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
