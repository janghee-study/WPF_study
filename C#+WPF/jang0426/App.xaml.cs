using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Threading;


namespace jang0426
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        private void ExceptionHandle(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            //MessageBox.Show("An unhandled exception just ocurred : " + e.Exception.Message, e.Dispatcher.Thread.Name, MessageBoxButton.OK, MessageBoxImage.Warning);
            Trace.WriteLine(e);
            e.Handled = true;
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            try
            {
                StartupUri = new Uri("./WINDOWS/MAIN.xaml", UriKind.Relative);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }
    }
}
