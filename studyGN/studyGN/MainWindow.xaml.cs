using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace studyGN
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Patient> Patients { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Patients = new ObservableCollection<Patient>
            {
                new Patient { No = 1, PatientId = "P001", PatientName = "John Doe", Gender = "Male", BirthDate = "1985-01-01", Age = 38, AccessNumber = "ACC123", StudyId = "ST001" },
                new Patient { No = 2, PatientId = "P002", PatientName = "Jane Smith", Gender = "Female", BirthDate = "1990-05-15", Age = 34, AccessNumber = "ACC456", StudyId = "ST002" },
                new Patient { No = 3, PatientId = "P003", PatientName = "Alice Brown", Gender = "Female", BirthDate = "1978-09-10", Age = 46, AccessNumber = "ACC789", StudyId = "ST003" }
            };
            DataContext = this;
        }
    }

    public class Patient
    {
        public int No { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string AccessNumber { get; set; }
        public string StudyId { get; set; }
    }
}

