using DataLayer.Models;
using DataLayer.Services;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOOP
{
    public partial class GoalsStatistics : Form
    {
        public DataService service = new DataService();
        List<PlayerStatistics> statisticList = new List<PlayerStatistics>();
        
        public string fifaCode = DataService.fifacode;

        public GoalsStatistics()
        {
            InitializeComponent();
            GetPlayers();
            flpGoals.VerticalScroll.Visible = true;
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
            flpGoals.Controls.Clear();
            await GetEvents(players, fifaCode);
            List<PlayerStatistics> sortedStatisticsList = statisticList.OrderBy(o => o.goals).Reverse().ToList();
            int itteration = 0;
            foreach (var item in sortedStatisticsList)
            {
                Player p = item.player;
                PlayerControl playerControl = new PlayerControl(p);
                playerControl.SetGoalsOrCardsValue($"Goals: { sortedStatisticsList[itteration].goals}");
                flpGoals.Controls.Add(playerControl);
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
                    if ((teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty"))
                    {
                        foreach (var player in statisticList)
                        {
                            if (teamEvent.Player == player.ToString())
                            {
                                player.goals++;
                            }
                        }
                    }
                }
                foreach (var teamEvent in matchResult.AwayTeamEvents)
                {
                    if ((teamEvent.TypeOfEvent == "goal" || teamEvent.TypeOfEvent == "goal-penalty"))
                    {
                        foreach (var player in statisticList)
                        {
                            if (teamEvent.Player == player.ToString())
                            {
                                player.goals++;
                            }
                        }
                    }
                }

            }
        }
    }
}

