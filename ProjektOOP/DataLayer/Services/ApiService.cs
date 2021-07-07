using DataLayer.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace DataLayer.Services
{
    public class ApiService : IService
    {
        private string maleTeamPath;
        public List<Team> GetTeams()
        {

            using (WebClient wc = new WebClient())
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
                var json = wc.DownloadString(maleTeamPath);
                List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);
                return teams;
            }
        }
         public  List<MatchResult> GetMatchResults()
        {
            return null;
        }
    }
}
