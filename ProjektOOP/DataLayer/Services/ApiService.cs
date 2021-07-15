using DataLayer.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class ApiService : IService
    {
        public string maleTeamPath = "https://world-cup-json-2018.herokuapp.com/teams";
        public string femaleTeamPath = "https://worldcup.sfg.io/teams/";
        public string maleMatchResults = "https://world-cup-json-2018.herokuapp.com/matches";
        public string femaleMatchResults = "https://worldcup.sfg.io/matches";
        string path;
        private ApplicationSettings applicationSettings = new ApplicationSettings();
        ApplicationSettingsService applicationSettingsService = new ApplicationSettingsService();


        public async Task<List<Team>> GetTeams()
        {
            path = maleTeamPath;
            //if (GetChampionship() == Championship.Male)
            //{
            //    path = maleTeamPath;
            //}
            //else
            //{
            //    path = femaleTeamPath;
            //}
            using (WebClient wc = new WebClient())
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
                var json = await wc.DownloadStringTaskAsync(path);
                List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);
                return teams;
            }
        }
        public Championship GetChampionship()
        {
            applicationSettings = applicationSettingsService.GetAplicationSettings();
            if (applicationSettings.Championship == Championship.Male)
            {
                return Championship.Male;
            }
            else
            {
                return Championship.Female;
            }
        }
        public async Task<List<MatchResult>> GetMatchResults()
        {

            if (GetChampionship() == Championship.Male)
            {
                path = maleMatchResults;
            }
            else
            {
                path = femaleMatchResults;
            }
            using (WebClient wc = new WebClient())
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
                var json = await wc.DownloadStringTaskAsync(path);
                List<MatchResult> results = JsonConvert.DeserializeObject<List<MatchResult>>(json);
                return results;
            }
        }
    }
}
