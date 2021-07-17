using DataLayer.Models;
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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for PlayerInformation.xaml
    /// </summary>
    public partial class PlayerInformation : Window
    {
        public Language language;
        public PlayerInformation(Player player, int goals, int yellowCards)
        {
            InitializeComponent();
            SetCulture();
            lblName.Content = $"{player.Name}";
            lblShirtNumber.Content = $"{player.ShirtNumber}";
            lblPosition.Content = $"{player.Position}";
            lblCaptain.Content = $"{player.Captain}";
            lblGoals.Content = $"{goals}";
            lblYellowCards.Content = $"{yellowCards}";

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
            Name.Content = TranslationService.GetTranslationByKey("name");
            ShirtNumber.Content = TranslationService.GetTranslationByKey("shirtNumber");
            Position.Content = TranslationService.GetTranslationByKey("position");
            Captain.Content = TranslationService.GetTranslationByKey("captain");
            GoalsScored.Content = TranslationService.GetTranslationByKey("goalsScored");
            YellowCards.Content = TranslationService.GetTranslationByKey("yellowCards");
        }
    }
}
