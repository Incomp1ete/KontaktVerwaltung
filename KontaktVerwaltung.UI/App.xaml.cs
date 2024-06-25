using KontaktVerwaltung.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace KontaktVerwaltung.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var vm = new MainViewModel();
            vm.CurrentViewModel = new KontaktBuchAnzeigeViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = vm,
            };
          
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
