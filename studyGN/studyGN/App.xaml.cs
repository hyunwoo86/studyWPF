using Microsoft.Extensions.DependencyInjection;
using studyGN.UserControls;
using studyGN.Windowos;
using System;
using System.Windows;

namespace studyGN
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Services = ConfigureServices();
            Startup += App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            var mainView = App.Current.Services.GetService<MainView>();
            mainView.Show();
        }

        public new static App Current => (App)Application.Current;

        public IServiceProvider Services { get; }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<MainView>();

            services.AddTransient<InitializeView>();
            services.AddTransient<LoginView>();

            return services.BuildServiceProvider();
        }
    }
}
