using studyGN.Commons;
using studyGN.Windowos;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace studyGN.ViewModel
{

    public class InitializeViewModel : NotifiyChangedBase
    {
        const int FONT_SIZE = 30;

        private ObservableCollection<Inline> _bindableInlineList;
        private Visibility _okButtonVisibility = Visibility.Visible;
        public ICommand OKButtonClick { get; }


        public InitializeViewModel()
        {
            BindableInlineList = new ObservableCollection<Inline>();
            OKButtonClick = new RelayCommand(OKButtonClickCommand);
            OKButtonVisibility = Visibility.Hidden;
            MakeInlineData(); // 임의로 테스트 하기 위해 만듦
        }

        ~InitializeViewModel()
        {
        }

        private void OKButtonClickCommand()
        {
            MainView.MovePageBlock.Post("LoginView"); // LoginView 이동
        }

        public ObservableCollection<Inline> BindableInlineList
        {
            get { return _bindableInlineList; }
            set
            {
                if (_bindableInlineList != value)
                {
                    _bindableInlineList = value;
                    OnPropertyChanged(nameof(BindableInlineList));
                }
            }
        }

        public Visibility OKButtonVisibility
        {
            get => _okButtonVisibility;
            set
            {
                if (_okButtonVisibility != value)
                {
                    _okButtonVisibility = value;
                    OnPropertyChanged(nameof(OKButtonVisibility));
                }
            }
        }

        private async void MakeInlineData()
        {
            for (int count = 0; count < 10; count++)
            {
                BindableInlineList.Add(new Run("NEXT LINE!") { Foreground = Brushes.Black, FontSize = FONT_SIZE, });
                BindableInlineList.Add(new LineBreak());

                if (count % 5 == 0)
                {
                    BindableInlineList.Add(new Run("Warning") { Foreground = Brushes.Orange, FontSize = FONT_SIZE, });
                    BindableInlineList.Add(new LineBreak());
                }

                if (count % 10 == 0)
                {
                    BindableInlineList.Add(new Run("Err") { Foreground = Brushes.Red, FontSize = FONT_SIZE, });
                    BindableInlineList.Add(new LineBreak());
                }

                await Task.Delay(200);
            }
            OKButtonVisibility = Visibility.Visible;

        }

    }

}

