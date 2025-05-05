namespace MauiApp1.Views;

public partial class EnvironmentalReportsPage : ContentPage
{
    public EnvironmentalReportsPage()
    {
        InitializeComponent();
    }

    private async void OnExportCsvClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Export", "CSV report downloaded!", "OK");
    }

    private async void OnExportPdfClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Export", "PDF report downloaded!", "OK");
    }
}
