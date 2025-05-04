using MauiApp1.Models;
using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class FaultReportingPage : ContentPage
{
    private FaultReportingViewModel vm;

    public FaultReportingPage()
    {
        InitializeComponent();

        // Pull from MainViewModel but don't modify it
        var allSensors = new MainViewModel().Sensors;
        vm = new FaultReportingViewModel(allSensors);
        BindingContext = vm;
    }

    private void OnReportFaultClicked(object sender, EventArgs e)
    {
        var sensor = (sender as Button)?.CommandParameter as Sensor;
        if (sensor != null)
            vm.ReportFault(sensor);
    }

    private void OnResolveClicked(object sender, EventArgs e)
    {
        var sensor = (sender as Button)?.CommandParameter as Sensor;
        if (sensor != null)
            vm.ResolveFault(sensor);
    }
}
