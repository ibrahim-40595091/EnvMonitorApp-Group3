using MauiApp1.Views; 

namespace MauiApp1
{
    public partial class App : Application
    {
        private IDispatcherTimer check;
        public App()
        {
            InitializeComponent();

            // Show login page first
            MainPage = new LoginPage();
            StartMaintenanceCheck();

        }

        private void OnTimerTick(object? sender, EventArgs e)
        {
            foreach(var sensor in AppData.Sensors)
            {
                 if (sensor.MaintenanceDate?.Date == DateTime.Today)
                 {
                    Application.Current.MainPage.DisplayAlert(" Maintenance Due", $"Sensor'{sensor.Name}' has maintenance scheduled for today", "OK");
                 }
            }
        }

         private void StartMaintenanceCheck()
            {
            check = Dispatcher.CreateTimer();
            check.Interval = TimeSpan.FromSeconds(10);
            check.Tick += OnTimerTick;
            }
    }
}
