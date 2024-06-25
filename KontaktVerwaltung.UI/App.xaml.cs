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
        //ToDo: Fody Configuration:
        // https://github.com/Fody/Home/blob/master/pages/usage.md
        // https://github.com/Fody/Home/blob/master/pages/configuration.md
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
