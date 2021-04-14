using System;
using System.Globalization;
using Xamarin.Forms;

namespace MotorMeans.Converters
{
    public class LiterConverter : BindableObject, IValueConverter
    {
        

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var returnValue = 0.0m;

            if (value == null || value.ToString() == "")
            {
                value = 0;
            }

            var liters = decimal.Parse(value.ToString());

            returnValue = liters * 61m;

            return decimal.Round(returnValue, 2);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var returnValue = 0.0m;

            if (value == null || value.ToString() == "")
            {
                value = 0;
            }

            var cubicInches = decimal.Parse(value.ToString());

            returnValue = cubicInches / 61m;

            return decimal.Round(returnValue, 2);
        }
    }
}
