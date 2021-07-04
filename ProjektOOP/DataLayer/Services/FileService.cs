using DataLayer.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DataLayer.Services
{
    public class FileService : IService
    {
        const string MatchResultPath = @"Resources\matches.json";
        public List<Team> GetTeams(string path)
        {    
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);                
                return teams;
            }        
        }
        public List<MatchResult> GetMatchResults()
        {
            using (StreamReader r=new StreamReader(MatchResultPath))
            {
                string json = r.ReadToEnd();
                List<MatchResult> results = JsonConvert.DeserializeObject<List<MatchResult>>(json);
                return results;
            }
        }
    }
}
