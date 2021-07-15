using DataLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public interface IService
    {
        Task<List<Team>> GetTeams();

        Task<List<MatchResult>> GetMatchResults();
    }
}
