using studyGN.Common;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace studyGN
{
    class MainViewModel : INotifyPropertyChanged
    {
        // ObservableCollection을 사용하여 동적으로 리스트를 관리
        public ObservableCollection<Thumbnail> Items { get; set; }

        // INotifyPropertyChanged 이벤트 구현
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            // 초기 데이터 설정
            Items = new ObservableCollection<Thumbnail>
            {
                new Thumbnail(),
                new Thumbnail(),
                new Thumbnail(),
                new Thumbnail(),
                new Thumbnail(),
                new Thumbnail(),
                new Thumbnail(),
            };
        }

        // PropertyChanged 이벤트를 호출하는 메서드
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


