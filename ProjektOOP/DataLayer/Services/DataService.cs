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
            var matchResult = MatchResults
                .Where(x => x.HomeTeamCountry == fifaCode || x.AwayTeamCountry == fifaCode ).OrderBy(x=>x.Datetime)
                .FirstOrDefault();    
            List<Player> players = new List<Player>();
            if (matchResult.HomeTeamCountry==fifaCode)
            {
                players.AddRange(matchResult.HomeTeamStatistics.StartingEleven);
                players.AddRange(matchResult.HomeTeamStatistics.Substitutes);
            }
            else
            {
                players.AddRange(matchResult.AwayTeamStatistics.StartingEleven);
                players.AddRange(matchResult.AwayTeamStatistics.Substitutes);
            }
            
            return players;
        }
    }   
}