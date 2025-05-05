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

    
}
