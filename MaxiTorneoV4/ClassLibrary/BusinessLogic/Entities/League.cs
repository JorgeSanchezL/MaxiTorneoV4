using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxiTorneo.Services;

namespace MaxiTorneo.Entities
{
    public partial class League
    {
        public League()
        {
            Teams = new List<Team>();
        }

        //No hay restricciones
        public League(string name):this()
        {
            this.Name = name;
        }

        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }
    }
}
