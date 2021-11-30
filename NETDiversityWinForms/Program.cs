using Autofac;
using Autofac.Extensions.DependencyInjection;
using ClassLibraryHelloUser;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace NETDiversityWinForms
{
    static class Program
    {
        private static IServiceProvider _serviceProvider;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegisterServices();

            var service = _serviceProvider.GetService<IHelloUser>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(service));

            DisposeServices();
        }

        private static void RegisterServices()
        {
            var collection = new ServiceCollection();
            var builder = new ContainerBuilder();

            builder.RegisterType<HelloUser>().As<IHelloUser>();
            builder.Populate(collection);

            var appContainer = builder.Build();

            _serviceProvider = new AutofacServiceProvider(appContainer);
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }
}
