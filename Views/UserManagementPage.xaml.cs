using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class UserManagementPage : ContentPage
{
    private UserViewModel vm;

    public UserManagementPage()
    {
        InitializeComponent();
        vm = new UserViewModel();
        BindingContext = vm;
    }

    private void OnAddUserClicked(object sender, EventArgs e)
    {
        vm.AddUser(NewUserName.Text, NewUserRole.Text);
        NewUserName.Text = string.Empty;
        NewUserRole.Text = string.Empty;
    }
}
