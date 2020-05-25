﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace The_Long_Dark_Save_Editor_2.Converters
{
    public class ObjectNotNullConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
