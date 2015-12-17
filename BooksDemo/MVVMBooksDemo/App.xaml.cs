using BooksDemo.Repositories;
using Microsoft.Extensions.DependencyInjection;
using MVVMBooksDemo.Services;
using MVVMBooksDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMBooksDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<IBooksRepository, BooksRepository>();
            services.AddSingleton<IBooksService, BooksService>();
            services.AddTransient<MainPageViewModel>();
            Container = services.BuildServiceProvider();
        }

        public IServiceProvider Container { get; private set; }
    }
}
