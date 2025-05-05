using MauiApp1.Views;

namespace MauiApp1.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnShowSensorsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
    
    private async void OnSetMaintenanceClicked(object sender, EventArgs e)
    {
    await Navigation.PushAsync(new MaintenancePage());
    }

    private async void OnSetFilePathClicked(object sender, EventArgs e)
    {
    await Navigation.PushAsync(new FilePathPage());
    }
    
}
