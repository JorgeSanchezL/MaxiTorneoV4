using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MaxiTorneo.Entities
{
    public partial class Team
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public virtual League League
        {
            get;
            set;
        }

        public virtual Person Person
        {
            get;
            set;
        }

        public virtual ICollection<Player> Players
        {
            get;
            set;
        }
    }
}
