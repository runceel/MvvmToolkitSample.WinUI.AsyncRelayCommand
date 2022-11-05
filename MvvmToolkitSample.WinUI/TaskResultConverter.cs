using CommunityToolkit.Common;
using Microsoft.UI.Xaml.Data;
using System;
using System.Threading.Tasks;

namespace MvvmToolkitSample.WinUI;

public sealed class TaskResultConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is Task task)
        {
            return task.GetResultOrDefault();
        }
        else if (value is null)
        {
            return null;
        }

        // Otherwise, we'll just pass through whatever value/result was given to us.
        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotSupportedException();
    }
}
