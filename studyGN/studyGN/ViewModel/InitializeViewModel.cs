using studyGN.Commons;
using studyGN.Windowos;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Documents;
using System.Windows.Media;

namespace studyGN.ViewModel
{

    public class InitializeViewModel : NotifiyChangedBase
    {
        const int FONT_SIZE = 30;

        private ObservableCollection<Inline> _bindableInlineList;

        public InitializeViewModel()
        {
            BindableInlineList = new ObservableCollection<Inline>();

            MakeInlineData(); // 임의로 테스트 하기 위해 만듦
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

        private async void MakeInlineData()
        {
            for(int count = 0; count < 15; count++)
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

                await Task.Delay(300);
            }

            MainView.MovePageBlock.Post("LoginView"); // LoginView 이동
        }

    }

}

