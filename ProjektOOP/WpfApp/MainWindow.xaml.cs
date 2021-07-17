﻿using DataLayer.Models;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public Language language;
        
        public MainWindow()
        {
            InitializeComponent();
            SetCulture();
            applicationSettings = service.GetAplicationSettings();
            if (applicationSettings==null)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr-HR");

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
        private void SetCulture()
        {
            DataService service = new DataService();
            language = service.GetLanguage();
            if (language == DataLayer.Models.Language.Croatian)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr-HR");
                TranslateForm();
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
               TranslateForm();
            }
        }
        private void TranslateForm()
        {
            rbCroatian.Content = TranslationService.GetTranslationByKey("croatianLanguage");
            rbEnglish.Content = TranslationService.GetTranslationByKey("englishLanguage");
            rbFemaleChampionship.Content = TranslationService.GetTranslationByKey("femaleChampionship");
            rbMaleChampionship.Content = TranslationService.GetTranslationByKey("maleChampionship");
            btnSave.Content = TranslationService.GetTranslationByKey("btnSave");
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
