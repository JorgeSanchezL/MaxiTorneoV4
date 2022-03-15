using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxiTorneo.Services;
using MaxiTorneo.Persistence;

namespace MaxiTorneo.Entities
{
    public partial class Player
    {
        IMaxiTorneoService service = new MaxiTorneoService(new EntityFrameworkDAL(new MaxiTorneoDbContext()));
        public Player()
        {
        
        }

        //Cambiar mensaje de la excepción
        public Player(string name, string position, Team team)
        {
            if (service.GetAllPlayers().Where(p => p.Team == team && p.Name == name).Count() > 0)
            {
                throw new ServiceException("Ya hay un jugador con este nombre en este equipo.");
            }
            this.Name = name;
            this.Position = position;
            this.Team = team;
            this.Person = null;
        }

        public void SetPerson(Person person)
        {
            Person = person;
        }
    }
}
