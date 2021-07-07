using DataLayer.Models;
using System.Collections.Generic;

namespace DataLayer.Services
{

    public interface IService
    {

        List<Team> GetTeams();

        //List<MatchResult> GetResults(string path);

        List<MatchResult> GetMatchResults();

        //Postavi omiljene igrace

        //List<Player> SetFavoritePlayers(string countryName);

        //Dohvati omiljene igrace
        //List<Player> GetFacoritePlayers(string fileName);

        //Postavi sliku igraca
        //PlayerPicture SetPlayerPicture(string playerName);

        //Dohvati sliku igraca
        //PlayerPicture GetPlayerPicture(string playerName);

        //Dohvati rang listu igraca(broj golova, broj zutih kartona, ispisati ime igraca i sliku)


        //Dohvatit rang listu posjetitelja(lokacija,broj posjetitelja, naziv domacina,naziv gosta)



    }
}
