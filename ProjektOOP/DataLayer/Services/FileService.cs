using DataLayer.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DataLayer.Services
{
    public class FileService : IService
    {
        ApplicationSettingsService applicationSettingsService = new ApplicationSettingsService();

        const string maleMatchResultPath = @"Resources\Malematches.json";
        private string maleTeamPath = @"Resources\Maleteams.json";
        public List<Team> GetTeams()
        {
            string path;
            ApplicationSettings applicationSettings = new ApplicationSettings();
            applicationSettings = applicationSettingsService.GetAplicationSettings();
            if (applicationSettings.Championship == Championship.Male)
            {
                path = maleTeamPath;
            }
            else
            {
                path = null;
            }
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);
                return teams;
            }

        }
        public List<MatchResult> GetMatchResults()
        {
            using (StreamReader r=new StreamReader(maleMatchResultPath))
            {
                string json = r.ReadToEnd();
                List<MatchResult> results = JsonConvert.DeserializeObject<List<MatchResult>>(json);
                return results;
            }
        }
    }
}
