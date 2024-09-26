using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace studyWPF
{
    class MainViewModel : ViewModelBase
    {
        public ICommand ChangeColorCommand { get; }

        private List<Student> students;
        public List<Student> Students
        {
            get => students;
            set
            {
                students = value;
                NotifyPropertyChanged();
            }
        }

        private object _currentViewModel;
        public object CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                NotifyPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public MainViewModel()
        {
            students = Student.Students;
            CurrentViewModel = new CurrentViewModel();
            ChangeColorCommand = new RelayCommand(ChangeColor);
        }


        private void ChangeColor(object parameter)
        {
            MessageBox.Show(".");
            CurrentViewModel = new SecondViewModel();
        }
    }
}
