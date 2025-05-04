    namespace MauiApp1.Views;

    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            var saveTime = DateTime.Now.ToString("HH:mm:ss tt, MMM dd yyyy");
            LastSavedLabel.Text = $"Last saved: {saveTime}";
        }
    }
