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
        List<MatchResult> results = DataService.MatchResults;
        public string fifaCode = DataService.fifacode;
        public YellowCardsStatistics()
        {
            InitializeComponent();
            GetPlayers();
        }
        private void GetPlayers()
        {
            List<Player> players = new List<Player>();
            players = service.GetPlayers(fifaCode);
            ShowPlayersStatistics(players, fifaCode);
        }

        private void ShowPlayersStatistics(List<Player> players, string fifaCode)
        {
            flpYellowCards.Controls.Clear();
            GetEvents(players, fifaCode);
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

        private void GetEvents(List<Player> players, string fifaCode)
        {

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
