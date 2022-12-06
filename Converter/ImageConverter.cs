using System;
using System.Windows.Data;

namespace estApp.Converter
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (value.ToString().ToLower())
            {
                case "vegetable":
                    return "/Resources/VegetableIcon.png";
                case "fruit":
                    return "/Resources/FruitIcon.png";
                default:
                    return "";
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
