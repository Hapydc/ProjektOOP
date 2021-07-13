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
        public static List<MatchResult> MatchResults { get; set; }
        private static string favoriteMalePlayersFile = @"ProgramGeneratedFiles\FavoriteMalePlayers.txt";
        private static string favoriteFemalePlayersFile = @"ProgramGeneratedFiles\FavoriteFemalePlayers.txt";
        private static string favoriteFemaleTeamFile = @"ProgramGeneratedFiles\FavoriteFemaleTeam.txt";
        private static string favoriteMaleTeamFile = @"ProgramGeneratedFiles\FavoriteMaleTeam.txt";
        private string dataSourceFile = @"ProgramGeneratedFiles\DataSource.txt";
        public string dataSource;
        public string selectedTeam;
        public static string fifacode;



        public DataService()
        {
            // TODO: čitaj iz datoteke
            UsesApiService = ReadDataSource();
            if (!UsesApiService)
            {
                Service = new FileService();
            }
            else
            {
                Service = new ApiService();
            }


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

        public List<MatchResult> GetAllMatchResults()
        {
            return Service.GetMatchResults();
        }

        public List<Player> GetPlayers(string fifaCode)
        {
            MatchResults = Service.GetMatchResults();
            var matchResult = MatchResults
                .Where(x => x.HomeTeamCountry == fifaCode || x.AwayTeamCountry == fifaCode).OrderBy(x => x.Datetime)
                .FirstOrDefault();
            List<Player> players = new List<Player>();
            if (matchResult.HomeTeamCountry == fifaCode)
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

        public void WriteFavoriteTeam(string fifaCode)
        {
            if (GetChampionship() == Championship.Male)
            {
                File.WriteAllText(favoriteMaleTeamFile, fifaCode);
            }
            else
            {
                File.WriteAllText(favoriteFemaleTeamFile, fifaCode);
            }


        }
        public string GetFavoriteTeam()
        {
            string fifaCode;
            Championship championship = GetChampionship();
            if (GetChampionship() == Championship.Male)
            {
                if (File.Exists(favoriteMaleTeamFile))
                {
                    fifaCode = File.ReadAllText(favoriteMaleTeamFile);

                }
                else
                {
                    fifaCode = null;
                }
            }
            else
            {
                if (File.Exists(favoriteFemaleTeamFile))
                {
                    fifaCode = File.ReadAllText(favoriteFemaleTeamFile);
                }
                else
                {
                    fifaCode = null;
                }
            }

            return fifaCode;
        }
        public Language GetLanguage()
        {
            
            ApplicationSettingsService applicationSettingsService = new ApplicationSettingsService();
            ApplicationSettings applicationSettings = applicationSettingsService.GetAplicationSettings();
            return applicationSettings.Language;
        }

        public void WriteFavoritePlayers(List<Player> players)
        {
            if (GetChampionship() == Championship.Male)
            {
                string json = JsonConvert.SerializeObject(players);
                if (GetChampionship() == Championship.Male)
                {

                    System.IO.File.WriteAllText(favoriteMalePlayersFile, json);
                }
            }
            else
            {
                string json = JsonConvert.SerializeObject(players);
                System.IO.File.WriteAllText(favoriteFemalePlayersFile, json);
            }

        }
        public List<Player> ReadFavoritePlayers()
        {
            string path;
            List<Player> players = new List<Player>();
            if (GetChampionship() == Championship.Male)
            {
                path = favoriteMalePlayersFile;
            }
            else
            {
                path = favoriteFemalePlayersFile;
            }
            if (File.Exists(path))
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    players = JsonConvert.DeserializeObject<List<Player>>(json);
                }
            }
            else
            {
                players = null;
            }

            return players;
        }

        public List<GamesInfo> GetGamesInfo()
        {
            string fifaCode = GetSelectedTeam();
            List<MatchResult> matchResults = Service.GetMatchResults();
            List<GamesInfo> gamesInfos = new List<GamesInfo>();
            List<MatchResult> matchResult = MatchResults
             .Where(x => x.HomeTeamCountry == fifaCode || x.AwayTeamCountry == fifaCode).ToList();
            for (int i = 0; i < matchResult.Count; i++)
            {
                    gamesInfos.Add(new Models.GamesInfo
                    {
                        Location = matchResult[i].Location,
                        Visitors = matchResult[i].Attendance,
                        HomeTeam = matchResult[i].HomeTeamCountry,
                        AwayTeam = matchResult[i].AwayTeamCountry,
                    }
                        );
                

            }
            return gamesInfos;
        }
        public Championship GetChampionship()
        {
            ApplicationSettings applicationSettings = new ApplicationSettings();
            ApplicationSettingsService applicationSettingsService = new ApplicationSettingsService();
            applicationSettings = applicationSettingsService.GetAplicationSettings();
            return applicationSettings.Championship;
        }
        public void SetSelectedTeam(string var)
        {
            fifacode = var;
        }
        public string GetSelectedTeam()
        {
            return fifacode;
        }
    }
}