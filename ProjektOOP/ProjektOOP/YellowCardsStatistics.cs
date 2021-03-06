using DataLayer.Models;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOOP
{
    public partial class YellowCardsStatistics : Form
    {
        private DataService service = new DataService();
        List<PlayerStatistics> statisticList = new List<PlayerStatistics>();
        public string fifaCode = DataService.fifacode;
        public YellowCardsStatistics()
        {
            InitializeComponent();
            GetPlayers();
        }
        private async void GetPlayers()
        {
            List<Player> players = new List<Player>();
            var loadingForm = new LoadingForm();
            loadingForm.Show();
            await Task.Run(async () =>
            {
                players = await service.GetPlayers(fifaCode);
            });
            loadingForm.Close();
            ShowPlayersStatistics(players, fifaCode);
        }

        private async void ShowPlayersStatistics(List<Player> players, string fifaCode)
        {

            flpYellowCards.Controls.Clear();
            await GetEvents(players, fifaCode);
            List<PlayerStatistics> sortedStatisticsList = statisticList.OrderBy(o => o.yellowCards).Reverse().ToList();
            int itteration = 0;
            foreach (var item in sortedStatisticsList)
            {
                Player p = item.player;
                PlayerControl playerControl = new PlayerControl(p);
                playerControl.SetGoalsOrCardsValue($"Yellow Cards: { sortedStatisticsList[itteration].yellowCards}");
                flpYellowCards.Controls.Add(playerControl);
                itteration++;
            }

        }

        private async Task GetEvents(List<Player> players, string fifaCode)
        {
            List<MatchResult> matchResults = await service.GetAllMatchResults();
            var results = matchResults.Where(x => x.HomeTeamCountry == fifaCode || x.AwayTeamCountry == fifaCode);

            foreach (var p in players)
            {
                statisticList.Add(new PlayerStatistics { player = p });
            }
            foreach (var matchResult in results)
            {
                foreach (var teamEvent in matchResult.HomeTeamEvents)
                {
                    if ((teamEvent.TypeOfEvent == "yellow-card"))
                    {
                        foreach (var player in statisticList)
                        {
                            if (teamEvent.Player == player.ToString())
                            {
                                player.yellowCards++;
                            }
                        }
                    }
                }
                foreach (var teamEvent in matchResult.AwayTeamEvents)
                {
                    if ((teamEvent.TypeOfEvent == "yellow-card"))
                    {
                        foreach (var player in statisticList)
                        {
                            if (teamEvent.Player == player.ToString())
                            {
                                player.yellowCards++;
                            }
                        }
                    }
                }

            }
        }

    }
}
