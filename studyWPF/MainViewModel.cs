using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyWPF
{
    class MainViewModel : ViewModelBase
    {
        private List<Student> students;

        public MainViewModel()
        {
            students = Student.Students;
            CurrentViewModel = new CurrentViewModel();
        }

        public List<Student> Students { get => students; set { students = value; NotifyPropertyChanged(); } }
        public ViewModelBase CurrentViewModel { get; set; }
    }
}
