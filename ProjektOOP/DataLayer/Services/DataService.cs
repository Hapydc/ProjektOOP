using DataLayer.Models;
using Newtonsoft.Json;
using System;
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
        private static string favoritePlayersFile = @"Resources\FavoritePlayers.txt";
        private static string favoriteTeamFile = @"Resources\FavoriteTeam.txt";
        private string dataSourceFile = @"ProgramGeneratedFiles\DataSource.txt";
     
        public string dataSource;
        private Championship championship;
        ApplicationSettingsService applicationSettingsService = new ApplicationSettingsService();
        public DataService()
        {
            // TODO: čitaj iz datoteke
            UsesApiService =ReadDataSource(); 
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

        private bool ReadDataSource()
        {
           StreamReader r = new StreamReader(dataSourceFile);
            dataSource = r.ReadToEnd();
            
            if (dataSource == "File")
            {
                return false; 
            }
            else
            {
                return true; 
            }

        }

        public List<Team> GetTeams()
        {           
            return Service.GetTeams();
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

        public static void WriteFavoriteTeam(string fifaCode)
        {
            File.WriteAllText(favoriteTeamFile,fifaCode);
        }
        public static string GetFavoriteTeam()
        {
            if (File.Exists(favoriteTeamFile))
            {
                string fifaCode = File.ReadAllText(favoriteTeamFile);
                return fifaCode;
            }
            else
            {
                return null;
            }
        }

        public static void WriteFavoritePlayers(List<Player> players)
        {
            string json = JsonConvert.SerializeObject(players);
            System.IO.File.WriteAllText(favoritePlayersFile, json);
        }
        public static List<Player> ReadFavoritePlayers()
        {
            List<Player> players = new List<Player>();
            if (File.Exists(favoritePlayersFile))
            {
                using (StreamReader r = new StreamReader(favoritePlayersFile))
                {
                    string json = r.ReadToEnd();
                    players = JsonConvert.DeserializeObject<List<Player>>(json);                  
                }
            }
          
            else
            {
               players= null;
            }
            return players;
        }
    }   
}