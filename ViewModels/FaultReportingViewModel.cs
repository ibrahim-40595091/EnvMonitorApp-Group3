using System.Collections.ObjectModel;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class FaultReportingViewModel
    {
        public ObservableCollection<Sensor> WorkingSensors { get; set; }
        public ObservableCollection<Sensor> FaultySensors { get; set; }

        public FaultReportingViewModel(IEnumerable<Sensor> allSensors)
        {
            // Split sensors into working and faulty
            WorkingSensors = new ObservableCollection<Sensor>(
                allSensors.Where(s => !s.IsFaulty)
            );

            FaultySensors = new ObservableCollection<Sensor>(
                allSensors.Where(s => s.IsFaulty)
            );
        }

        public void ReportFault(Sensor sensor)
        {
            if (WorkingSensors.Remove(sensor))
            {
                sensor.IsFaulty = true;
                FaultySensors.Add(sensor);
            }
        }

        public void ResolveFault(Sensor sensor)
        {
            if (FaultySensors.Remove(sensor))
            {
                sensor.IsFaulty = false;
                WorkingSensors.Add(sensor);
            }
        }
    }
}
