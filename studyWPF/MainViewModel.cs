using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace studyWPF
{
    class MainViewModel : ViewModelBase
    {
        private List<Student> students;
        public ICommand MyButtonCommand { get; }

        public MainViewModel()
        {
            students = Student.Students;
            CurrentViewModel = new CurrentViewModel();
            MyButtonCommand = new RelayCommand(ChangeColorEvent);

        }

        public List<Student> Students { get => students; set { students = value; NotifyPropertyChanged(); } }
        public ViewModelBase CurrentViewModel { get; set; }

        private void ChangeColorEvent(object parameter)
        {
            System.Windows.MessageBox.Show("Button Clicked!");
        }
    }
}
