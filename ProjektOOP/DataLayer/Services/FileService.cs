using DataLayer.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DataLayer.Services
{
    public class FileService : IService
    {
        public List<Team> GetTeams(string path)
        {

            
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);                
                return teams;
            }
            
        }
        public List<MatchResult> GetMatchResults(string path)
        {
            using (StreamReader r=new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<MatchResult> results = JsonConvert.DeserializeObject<List<MatchResult>>(json);
                return results;
            }
        }
        public List<Player> GetPlayers(List<MatchResult> results, string fifaCode)
        {
            return null;
        }


    }
}
