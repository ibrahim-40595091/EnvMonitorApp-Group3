using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class DataValidationPage : ContentPage
{
    private DataValidationViewModel vm;

    public DataValidationPage()
    {
        InitializeComponent();
        vm = new DataValidationViewModel();
        BindingContext = vm;
    }

    private void CheckDataClicked(object sender, EventArgs e)
    {
        vm.RunValidation();
    }
}
