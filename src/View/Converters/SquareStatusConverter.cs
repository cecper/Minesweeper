using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace View.Converters
{
    public class SquareStatusConverter : IValueConverter
    {
        public Object Uncovered { get; set; }
        public Object Covered { get; set; }
        public Object Flagged { get; set; }
        public Object Mine { get; set; }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var squareStatus=(SquareStatus)value;
            switch (squareStatus)
            {
                case SquareStatus.Uncovered:
                    return Uncovered;

                case SquareStatus.Covered:
                    return Covered;

                case SquareStatus.Mine:
                    return Mine;

                case SquareStatus.Flagged:
                    return Flagged;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
