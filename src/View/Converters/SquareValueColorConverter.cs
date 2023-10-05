using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Shapes;

namespace View.Converters
{
    internal class SquareValueColorConverter : IValueConverter
    {
        public Object Zero { get; set; }
        public Object One { get; set; }
        public Object Two { get; set; }
        public Object Three { get; set; }
        public Object Four { get; set; }
        public Object Five { get; set; }
        public Object Six { get; set; }
        public Object Seven { get; set; }
        public Object Eight { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var squareStatus = (Square)value;
            switch (squareStatus.NeighboringMineCount)
            {
                case 0:
                    return Zero;
                case 1:
                    return One;
                case 2:
                    return Two;
                case 3:
                    return Three;
                case 4:
                    return Four;
                case 5:
                    return Five;
                case 6:
                    return Six;
                case 7:
                    return Seven;
                case 8:
                    return Eight;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
