using DataLayer.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DataLayer.Services
{
    public class FileService : IService
    {
        ApplicationSettingsService applicationSettingsService = new ApplicationSettingsService();

        const string maleMatchResultPath = @"Resources\MaleMatches.json";
        private string maleTeamPath = @"Resources\MaleTeams.json";
        private string femaleTeamPath= @"Resources\FemaleTeams.json";
        private string femaleMatchResultPath= @"Resources\FemaleMatches.json";
        private string path;
        private  ApplicationSettings applicationSettings = new ApplicationSettings();
         
        public List<Team> GetTeams()
        {
            applicationSettings = applicationSettingsService.GetAplicationSettings();
            if (applicationSettings.Championship == Championship.Male)
            {
                path = maleTeamPath;
            }
            else
            {
                path = femaleTeamPath;
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
            applicationSettings = applicationSettingsService.GetAplicationSettings();
            if (applicationSettings.Championship == Championship.Male)
            {
                path = maleMatchResultPath;
            }
            else
            {
                path = femaleMatchResultPath;
            }
            using (StreamReader r=new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<MatchResult> results = JsonConvert.DeserializeObject<List<MatchResult>>(json);
                return results;
            }
        }
    }
}
