using DataLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Services
{
    public class DataService
    {
        public bool UsesApiService { get; set; }
        private IService Service;
        private List<MatchResult> MatchResults { get; set; }

        public DataService()
        {
            // TODO: čitaj iz datoteke
            UsesApiService = false;
            if (!UsesApiService)
            {
               Service = new FileService();
            }
            else
            {
                Service = new ApiService();
            }

            MatchResults = Service.GetMatchResults();
        }

        public List<Team> GetTeams(string path)
        {
            return Service.GetTeams(path);
        }

        public List<Player> GetPlayers(string fifaCode)
        {
            var matchResult = MatchResults.Where(x => x.HomeTeamCountry == fifaCode).FirstOrDefault();
            List<Player> players = new List<Player>();
            players.AddRange(matchResult.HomeTeamStatistics.StartingEleven);
            players.AddRange(matchResult.HomeTeamStatistics.Substitutes);

            return players;
        }
    }   
}