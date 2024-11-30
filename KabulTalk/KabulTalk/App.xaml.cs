using KabulTalk.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
            var mainView = App.Current.Services.GetService<MainWindow>();
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
            services.AddSingleton<MainWindow>();

            return services.BuildServiceProvider();
        }
    }
}
