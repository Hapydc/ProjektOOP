using DataLayer.Models;
using System.Collections.Generic;

namespace DataLayer.Services
{
    public class DataService
    {
        public bool UsesApiService { get; set; }
        private IService Service;

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
        }


        public List<Team> GetTeams(string path)
        {
            return Service.GetTeams(path);
        }
        public List<MatchResult> GetMatchResults(string path)
        {
            return Service.GetMatchResults(path);
        }

        public List<Player> GetPlayers(List<MatchResult> results, string fifaCode)
        {
            MatchResult match = new MatchResult();
            List<Player> players = new List<Player>();
            for (int i = 0; i < results.Count; i++)
            {
                if (results[i].HomeTeamCountry == fifaCode)
                {
                    match = results[i];
                    match.HomeTeamStatistics.StartingEleven.ForEach(p => players.Add(p));
                    match.HomeTeamStatistics.Substitutes.ForEach(p => players.Add(p));
                    if (players.Count == 23)
                    {
                        break;
                    }
                }
            }
            return players;
        }


    }
   
}
