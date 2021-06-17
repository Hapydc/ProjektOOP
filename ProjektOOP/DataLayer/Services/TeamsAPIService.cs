using DataLayer.Models;
using Newtonsoft.Json;
using ProjektOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class TeamsAPIService : ITeamService
    {

        public List<Team> GetTeams(string path)
        {
            
            using (WebClient wc = new WebClient())
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
                var json = wc.DownloadString(path);
                List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);
                return teams;
            }
            

        }

        public void Test() { }
    }
}
