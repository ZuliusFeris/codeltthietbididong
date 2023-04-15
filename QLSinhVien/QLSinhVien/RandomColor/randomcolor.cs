using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;

namespace QLSinhVien.RandomColor
{
    
        public class randomcolor : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                // Tạo màu ngẫu nhiên
                var random = new Random();
                var color = Color.FromRgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

                // Trả về giá trị Color
                return color;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }

        }
    
}
