using studyGN.Commons;
using studyGN.UserControls;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;
using System.Windows;

namespace studyGN.Windowos
{
    /// <summary>
    /// MainView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : Window
    {
        private static readonly BroadcastBlock<string> MovePageBlock = new BroadcastBlock<string>(null);

        public MainView()
        {
            InitializeComponent();

            MovePageBlock.LinkTo(new ActionBlock<string>(pageName => MovePage(pageName)));
            MovePageBlock.Post("Initialize");
        }

        private readonly Dictionary<string, InitializableUserControl> PageSelector = new Dictionary<string, InitializableUserControl>()
        {
            { "Initialize", new InitializeView() },
            { "LoginView", new LoginView() },
        };

        private void MovePage(string route)
        {
            Dispatcher.Invoke(() =>
            {
                MainContent.Content = PageSelector[route];
            });
        }

    }
}
