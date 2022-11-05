using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmToolkitSample.WinUI;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    private async Task<string> SayHello()
    {
        await Task.Delay(3000);
        return $"Hello world at {DateTime.Now.ToString(CultureInfo.InvariantCulture)}";
    }
}
