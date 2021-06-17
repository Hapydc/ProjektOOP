using Newtonsoft.Json;
using ProjektOOP;
using System.Collections.Generic;
using System.IO;

namespace DataLayer.Services
{
    public class TeamsFileService : ITeamService
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
    }
}
