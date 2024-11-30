using KabulTalk.Services;
using KabulTalk.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace KabulTalk
{
    public sealed partial class App : Application
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

            // services
            services.AddSingleton<ITestService, TestService>(); // 결합도를 낮춰준다.

            // view
            services.AddSingleton<MainView>();

            return services.BuildServiceProvider();
        }
    }
}
