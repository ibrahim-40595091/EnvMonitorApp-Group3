using System.Collections.ObjectModel;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class UserViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public UserViewModel()
        {
            Users = new ObservableCollection<User>
            {
                new User { Name = "Abdullahi Ali", Role = "Administrator" },
                new User { Name = "Abdirahman Ali", Role = "Operations Manager" },
                new User { Name = "Ibrahim Osman", Role = "Environmental Scientist" },
                new User { Name = "Jinson Thayil", Role = "Administrator" }
            };
        }

        public void AddUser(string name, string role)
        {
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(role))
                Users.Add(new User { Name = name, Role = role });
        }
    }
}
