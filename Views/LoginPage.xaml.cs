namespace MauiApp1.Views;

public partial class LoginPage : ContentPage
{
    // Password
    private const string _appPassword = "Secure1234!";  

    public LoginPage()
    {
        InitializeComponent();
    }

    // action for when login is initiated 
    private async void LoginButtonClicked(object sender, EventArgs e)
    {
        if (PasswordEntry.Text == _appPassword)
        {
            Application.Current.MainPage = new AppShell(); 
        }
        else
        {
            await DisplayAlert("Error", "Incorrect password!", "OK");
        }
    }
}
