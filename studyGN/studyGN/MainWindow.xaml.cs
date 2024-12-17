using log4net;
using System.Windows;

namespace studyGN
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MainWindow));

        public MainWindow()
        {
            InitializeComponent();

            // log4net 초기화
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));

            // 로그 기록
            log.Info("This is an info message");
            log.Warn("This is a warning message");
            log.Error("This is an error message");
        }
    }
}
