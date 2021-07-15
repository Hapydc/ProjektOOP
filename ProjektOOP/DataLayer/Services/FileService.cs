using DataLayer.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class FileService : IService
    {
        ApplicationSettingsService applicationSettingsService = new ApplicationSettingsService();

        const string maleMatchResultPath = @"Resources\MaleMatches.json";
        private string maleTeamPath = @"Resources\MaleTeams.json";
        private string femaleTeamPath = @"Resources\FemaleTeams.json";
        private string femaleMatchResultPath = @"Resources\FemaleMatches.json";
        private string path;
        private ApplicationSettings applicationSettings = new ApplicationSettings();


        private Championship GetChampionship()
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

        public async Task<List<Team>> GetTeams()
        {

            if (GetChampionship() == Championship.Male)
            {
                path = maleTeamPath;
            }
            else
            {
                path = femaleTeamPath;
            }
            using (StreamReader r = new StreamReader(path))
            {
                string json = await r.ReadToEndAsync();
                List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);
                return teams;
            }

        }
        public async Task<List<MatchResult>> GetMatchResults()
        {

            if (GetChampionship() == Championship.Male)
            {
                path = maleMatchResultPath;
            }
            else
            {
                path = femaleMatchResultPath;
            }
            using (StreamReader r = new StreamReader(path))
            {
                string json = await r.ReadToEndAsync();
                List<MatchResult> results = JsonConvert.DeserializeObject<List<MatchResult>>(json);
                return results;
            }
        }
    }
}
