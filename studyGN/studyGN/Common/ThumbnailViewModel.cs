using studyGN.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace studyGN.Common
{
    class ThumbnailViewModel : NotifiyChangedBase
    {
        private string _operationType;
        private string _positionType;
        private bool _isSelected;
        public ICommand SelectCommand { get; }

        public ThumbnailViewModel(string operationType, string positionType, bool isSelected = false)
        {
            _operationType = operationType;
            _positionType = positionType;
            _isSelected = isSelected;
            SelectCommand = new RelayCommand(OnSelect);
        }

        public string OperationType
        {
            get { return _operationType; }
            set
            {
                _operationType = value;
                OnPropertyChanged();
            }
        }

        public string PositionType
        {
            get { return _positionType; }
            set { _positionType = value; OnPropertyChanged(); }
        }

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                if (_isSelected != value)
                {
                    _isSelected = value;
                    OnPropertyChanged();
                }
            }
        }


        private void OnSelect(object parameter)
        {
            if (parameter is ThumbnailViewModel selectedItem)
            {
                //// 외부에서 관리하는 로직에 따라 다른 항목을 선택 해제
                //foreach (var item in _parentCollection)
                //{
                //    item.IsSelected = false;
                //}

                // 현재 항목만 선택
                IsSelected = true;
            }
        }
    }
}

