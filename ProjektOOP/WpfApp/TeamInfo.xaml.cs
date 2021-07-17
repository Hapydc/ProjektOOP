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
    /// Interaction logic for TeamInfo.xaml
    /// </summary>
    public partial class TeamInfo : Window
    {
        private Language language;
        public TeamInfo(TeamInformation teamInformation)
        {
            InitializeComponent();
            SetCulture();
            lblName.Content = teamInformation.Country;
            lblFifaCode.Content = teamInformation.FifaCode;
            lblGames.Content = teamInformation.GamesPlayed.ToString();
            lblWins.Content = teamInformation.Wins.ToString();
            lblDefeats.Content = teamInformation.Losses.ToString();
            lblDraws.Content = teamInformation.Draws.ToString();
            lblScored.Content = teamInformation.GoalsFor.ToString();
            lblRecieved.Content = teamInformation.GoalsAgainst.ToString();
            lblGoalDiff.Content = teamInformation.GoalDifferential.ToString();

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
            FifaCode.Content = TranslationService.GetTranslationByKey("fifaCode");
            Wins.Content = TranslationService.GetTranslationByKey("wins");
            Draws.Content = TranslationService.GetTranslationByKey("draws");
            Losses.Content = TranslationService.GetTranslationByKey("defeats");
            Games.Content= TranslationService.GetTranslationByKey("games");
            GoalsScored.Content = TranslationService.GetTranslationByKey("goalsScored");
            GoalsRecieved.Content = TranslationService.GetTranslationByKey("goalsRecieved");
            GoalDifference.Content = TranslationService.GetTranslationByKey("goalDifference");
        }
    }
}
