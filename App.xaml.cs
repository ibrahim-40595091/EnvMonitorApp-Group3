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
            // Strats the maintenance check method taht runs on a timer 
            StartMaintenanceCheck();

        }


        // Every time the timer ticks this method is called bythe check.Tick+= OnTimerTick
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
            // creates a timer 
            check = Dispatcher.CreateTimer();
            // sets the interval
            check.Interval = TimeSpan.FromSeconds(10);
            // calls method once timer ticks
            check.Tick += OnTimerTick;
            }
    }
}
