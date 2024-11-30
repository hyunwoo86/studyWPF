using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using WpfLib.Extensions;

namespace KabulTalk.Controls
{
    /// <summary>
    /// TitleBar.xaml에 대한 상호 작용 논리
    /// </summary>

    public partial class TitleBar : UserControl, INotifyPropertyChanged
    {
        private Window _parentWindow;
        private WindowState _winState;

        public event PropertyChangedEventHandler PropertyChanged;

        public WindowState WinState
        {
            get { return _winState; }
            set 
            {
                _winState = value;
                OnPropertyChanged(nameof(WinState));
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Window ParentWindow
        {
            set { _parentWindow = value; }
            get
            {
                if (_parentWindow == null)
                {
                    _parentWindow = this.FindParent<Window>();
                }
                return _parentWindow;
            }

        }

        public TitleBar()
        {
            InitializeComponent();

            btnExit.Click += BtnExit_Click;
            btnMaximize.Click += BtnMaximize_Click;
            btnMinimize.Click += BtnMinimize_Click;
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            //// 이렇게 사용하면 매번 재귀함수로 호출되어서 비효율
            //btnMinimize.FindParent<Window>().WindowState = WindowState.Minimized;

            WinState = WindowState.Minimized;
            ParentWindow.WindowState = WinState;
        }

        private void BtnMaximize_Click(object sender, RoutedEventArgs e)
        {
            WinState = ParentWindow.WindowState == WindowState.Maximized
                ? WindowState.Normal
                : WindowState.Maximized;

            ParentWindow.WindowState = WinState;

            //btnMinimize.FindParent<Window>().WindowState = WindowState.Maximized;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            //btnMinimize.FindParent<Window>().Close();
            ParentWindow.Close();
        }
    }
}
