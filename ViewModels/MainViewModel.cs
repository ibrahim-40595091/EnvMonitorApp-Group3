using System.Collections.ObjectModel;
using MauiApp1.Models;  

namespace MauiApp1.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Sensor> Sensors => AppData.Sensors;


        }
    }
