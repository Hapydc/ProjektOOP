using DataLayer.Models;
using System.Collections.Generic;

namespace DataLayer.Services
{
    public class DataService : IService
    {
        public List<Team> GetTeams(string path)
        {
            if (path.Contains("http"))
            {
                ApiService service = new ApiService();
                List<Team> teams = service.GetTeams(path);
                return teams;

            }
            else
            {
                FileService service = new FileService();
                List<Team> teams = service.GetTeams(path);
                return teams;
            }
        }
        public List<MatchResult> GetMatchResults(string path)
        {
            if (path.Contains("http"))
            {
                ApiService service = new ApiService();
                List<MatchResult> results = service.GetMatchResults(path);
                return results;
            }
            else
            {
                FileService service = new FileService();
                List<MatchResult> results = service.GetMatchResults(path);
                return results;
            }
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
