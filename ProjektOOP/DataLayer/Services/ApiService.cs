﻿using DataLayer.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace DataLayer.Services
{
    public class ApiService : IService
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
         public  List<MatchResult> GetMatchResults()
        {
            return null;
        }
    }
}
