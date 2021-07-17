using DataLayer.Models;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void ApplicationStart(object sender, StartupEventArgs e)
        {
            var service = new ApplicationSettingsService();
            var applicationSettings = service.GetAplicationSettings();
            
            if (applicationSettings == null)
            {
                SetLanguage(Language.Croatian);
                var mainWindow = new MainWindow();
                Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                Current.MainWindow = mainWindow;
                mainWindow.Show();
            }
            else
            {
                SetLanguage(applicationSettings.Language);
                TeamsWindow teamsWindow = new TeamsWindow();
                Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                Current.MainWindow = teamsWindow;
                teamsWindow.Show();
            }
        }

        private void SetLanguage(Language language)
        {
            ResourceDictionary dict = new ResourceDictionary();
            if (language == Language.Croatian)
            {
                dict.Source = new Uri("Resources\\Resource.hr-HR.xaml",
                                      UriKind.Relative);
            } else
            {
                dict.Source = new Uri("Resources\\Resource.en.xaml",
                                       UriKind.Relative);
            }

            this.Resources.MergedDictionaries.Add(dict);
        }
    }
}
