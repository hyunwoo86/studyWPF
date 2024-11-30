using KabulTalk.Services;
using System.Windows;

namespace KabulTalk
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(ITestService testService)
        {
            InitializeComponent();

            /* 결합도가 높은 상황 (직접 주입)  */
            //ITestService service = new TestService();
            //MessageBox.Show(service.GetString());

            /* 결합도를 낮춘 상황 (DI 적용) */
            MessageBox.Show(testService.GetString());
        }
    }
}
