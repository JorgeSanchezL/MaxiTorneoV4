using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxiTorneo.Services;
using MaxiTorneo.Persistence;

namespace MaxiTorneo.Entities
{
    public partial class Team
    {
        IMaxiTorneoService service = new MaxiTorneoService(new EntityFrameworkDAL(new MaxiTorneoDbContext()));
        public Team()
        {
            Players = new List<Player>();
        }

        //Cambiar mensaje
        public Team(string name, League league):this()
        {
            if (service.GetAllTeams().Where(t => t.League == league && t.Name == name).Count() > 0)
            {
                throw new ServiceException("Ya hay un equipo con este nombre en esta liga.");
            }
            this.Name = name;
            this.League = league;
            this.Person = null;
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
    }
}
