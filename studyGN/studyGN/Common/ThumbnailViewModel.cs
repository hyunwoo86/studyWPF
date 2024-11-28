using studyGN.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyGN.Common
{
    class ThumbnailViewModel : NotifiyChangedBase
    {

        private string _operationType;

        public string OperationType
        {
            get { return _operationType; }
            set
            {
                _operationType = value;
                OnPropertyChanged();
            }
        }

        private string _positionType;

        public string PositionType
        {
            get { return _positionType; }
            set { _positionType = value; OnPropertyChanged(); }
        }



        public ThumbnailViewModel(string operationType, string positionType)
        {
            _operationType = operationType;
            _positionType = positionType;
        }
    }
}

