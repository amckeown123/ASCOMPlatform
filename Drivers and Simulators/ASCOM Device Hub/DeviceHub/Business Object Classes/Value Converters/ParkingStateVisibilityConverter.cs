﻿using System;
using System.Windows;
using System.Windows.Data;

namespace ASCOM.DeviceHub
{
	public class ParkingStateVisibilityConverter : IValueConverter
	{
		public object Convert( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
		{
            ParkingStateEnum state = (ParkingStateEnum)value;
			ParkingStateEnum visibleState = (ParkingStateEnum)parameter;

            Visibility visibility = state == visibleState ? Visibility.Visible : Visibility.Hidden;

            return visibility;
		}

		public object ConvertBack( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture )
		{
			throw new NotImplementedException();
		}
	}
}
