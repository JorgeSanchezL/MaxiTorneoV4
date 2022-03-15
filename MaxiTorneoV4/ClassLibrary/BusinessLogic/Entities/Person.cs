using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxiTorneo.Services;
using MaxiTorneo.Persistence;

namespace MaxiTorneo.Entities
{
    public partial class Person
    {
        IMaxiTorneoService service = new MaxiTorneoService(new EntityFrameworkDAL(new MaxiTorneoDbContext()));
        public Person()
        {
            Players = new List<Player>();
        }

        public Person(string name, Team team):this()
        {
            if (service.GetAllPersons().Where(p => p.Name == name).Count() > 0)
            {
                throw new ServiceException("Ya hay una persona con este nombre.");
            }
            this.Name = name;
            this.Team = team;
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
    }
}
