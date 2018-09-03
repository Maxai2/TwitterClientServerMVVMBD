using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using TwitterClientServerMVVMBD.Interface;
using TwitterClientServerMVVMBD.View;

namespace TwitterClientServerMVVMBD
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IContainer Container { get; private set; }

        public App()
        {
            var builder = new ContainerBuilder();

            #region View
            builder.RegisterType<MainWindow>().As<IMainWindow>().SingleInstance();
            builder.RegisterType<LoginWindow>().As<ILoginWindow>().SingleInstance();
            #endregion
            #region ModelView
            builder.RegisterType<MainWindowModelView>().As<IMainWindowModelView>().SingleInstance();
            builder.RegisterType<LoginWindowModelView>().As<ILoginWindowModelView>().SingleInstance();
            #endregion

            Container = builder.Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var viewModel = Container.Resolve<IMainWindowViewModel>();
            var mainView = viewModel.View;
            this.MainWindow = mainView as Window;
            this.MainWindow.Show();
        }
    }
}
