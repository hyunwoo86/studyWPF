using System;
using System.Windows;
using System.Windows.Input;

namespace studyGN.ViewModels
{
    internal class ClearCommand : ICommand
    {
        private MainViewModel mainViewModel;

        public ClearCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show($"Text1: {mainViewModel.Text1}, Text2: {mainViewModel.Text2}");
            mainViewModel.Text1 = "";
            mainViewModel.Text2 = "";
        }
    }
}