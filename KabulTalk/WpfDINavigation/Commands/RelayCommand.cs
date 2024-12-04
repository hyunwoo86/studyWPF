using System;
using System.Windows.Input;

namespace WpfDINavigation.Commands
{
    public class RelayCommand<T> : ICommand
    {
        readonly Predicate<T> _canExecute;
        readonly Action<T> _execute;

        public RelayCommand(Action<T> action, Predicate<T> predicate)
        {
            _execute = action;
            _canExecute = predicate;
        }
        public RelayCommand(Action<T> action) : this(action, null)
        {
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute.Invoke((T)parameter);
        }
        public void Execute(object parameter)
        {
            _execute.Invoke((T)parameter);
        }
    }
}
