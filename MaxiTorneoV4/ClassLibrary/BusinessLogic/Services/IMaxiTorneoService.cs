using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxiTorneo.Entities;


namespace MaxiTorneo.Services
{
    public interface IMaxiTorneoService
    {
        void RemoveAllData();
        void Commit();

        void NewPerson(Person person);
        void NewPlayer(Player player);
        void NewLeague(League league);
        void NewTeam(Team team);

        IEnumerable<Person> GetAllPersons();
        IEnumerable<Player> GetAllPlayers();
        IEnumerable<Team> GetAllTeams();
        IEnumerable<League> GetAllLeagues();
    }
}
