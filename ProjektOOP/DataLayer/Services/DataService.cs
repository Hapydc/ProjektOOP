using DataLayer.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataLayer.Services
{
    public class DataService
    {
        public bool UsesApiService { get; set; }
        private IService Service;
        private List<MatchResult> MatchResults { get; set; }
        private static string favoritePlayersDocument = @"Resources\FavoritePlayers.txt";

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
        public static void WriteFavoritePlayers(List<Player> players)
        {
            string json = JsonConvert.SerializeObject(players);
            System.IO.File.WriteAllText(favoritePlayersDocument, json);
        }
        public static List<Player> ReadFavoritePlayers()
        {
           using(StreamReader r=new StreamReader(favoritePlayersDocument))
            {
                string json = r.ReadToEnd();
                List<Player> players = JsonConvert.DeserializeObject<List<Player>>(json);
                return players;
            }
        }
    }   
}