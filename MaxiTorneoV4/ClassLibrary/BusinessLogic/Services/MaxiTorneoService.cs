using MaxiTorneo.Entities;
using MaxiTorneo.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MaxiTorneo.Services
{
    public class MaxiTorneoService : IMaxiTorneoService
    {
        private readonly IDAL dal;

        public MaxiTorneoService(IDAL dal)
        {
            this.dal = dal;
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void NewPerson(Person person)
        {
            dal.Insert<Person>(person);
            dal.Commit();
        }

        public void NewPlayer(Player player)
        {
            dal.Insert<Player>(player);
            dal.Commit();
        }

        public void NewLeague(League league)
        {
            dal.Insert<League>(league);
            dal.Commit();
        }

        public void NewTeam(Team team)
        {
            dal.Insert<Team>(team);
            dal.Commit();
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return dal.GetAll<Person>();
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            return dal.GetAll<Player>();
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return dal.GetAll<Team>();
        }
        public IEnumerable<League> GetAllLeagues()
        {
            return dal.GetAll<League>();
        }
    }
}
