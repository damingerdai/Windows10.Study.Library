﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows10.Study.Library.Background;

namespace Windows10.Study.Library.Core
{
    public class ScenarioBindingConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Scenario s = value as Scenario;
            //int index = MainPage.Current.Scenarios.IndexOf(s);
            //return index + "." + s.ToString() ;
            return (MainPage.Current.Scenarios.IndexOf(s) + 1) + " . " + s.Title;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value;
        }
    }
}
