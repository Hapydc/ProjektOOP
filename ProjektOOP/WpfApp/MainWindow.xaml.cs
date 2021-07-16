using DataLayer.Models;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ApplicationSettings applicationSettings = new ApplicationSettings();
        public ApplicationSettingsService service = new ApplicationSettingsService();
        public MainWindow()
        {
            InitializeComponent();
            applicationSettings = service.GetAplicationSettings();
            if (applicationSettings==null)
            {

            }
            else
            {
                if (applicationSettings.Championship==Championship.Male)
                {
                    rbMaleChampionship.IsChecked = true;
                }
                else
                {
                    rbFemaleChampionship.IsChecked = true;
                }
                if (applicationSettings.Language==DataLayer.Models.Language.Croatian)
                {
                    rbCroatian.IsChecked = true;

                }
                else
                {
                    rbEnglish.IsChecked = true;
                }
            }
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            ApplicationSettings applicationSettings = new ApplicationSettings();
            ApplicationSettingsService service = new ApplicationSettingsService();
            if (rbMaleChampionship.IsChecked==true)
            {
                applicationSettings.Championship = Championship.Male;
            }
            else
            {
                applicationSettings.Championship = Championship.Female;
            };
            if (rbCroatian.IsChecked==true)
            {
                applicationSettings.Language = DataLayer.Models.Language.Croatian;
            }
            else
            {
                applicationSettings.Language = DataLayer.Models.Language.English;
            }
            service.SaveAplicationSettings(applicationSettings);

            TeamsWindow teamsWindow = new TeamsWindow();
            this.Hide();
            teamsWindow.Show();
            this.Close();

        }
        


    }
}
