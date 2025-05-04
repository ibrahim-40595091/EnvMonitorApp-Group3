using MauiApp1.Views; 

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Show login page first
            MainPage = new LoginPage();
        }
    }
}
