using System;
using System.Windows.Data;
using TestApp.Models;

namespace TestApp.Converter
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Fruit)
                return "/Resources/FruitIcon.png";
            else
                return "/Resources/VegetableIcon.png";
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
