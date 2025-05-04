namespace MauiApp1.Views;

public partial class LoginPage : ContentPage
{
    private const string _appPassword = "Secure1234!";  // Your chosen password

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void LoginButtonClicked(object sender, EventArgs e)
    {
        if (PasswordEntry.Text == _appPassword)
        {
            Application.Current.MainPage = new AppShell(); // Navigate to main app
        }
        else
        {
            await DisplayAlert("Error", "Incorrect password!", "OK");
        }
    }
}
