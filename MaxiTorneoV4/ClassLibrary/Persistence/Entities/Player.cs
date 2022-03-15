using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MaxiTorneo.Entities
{
    public partial class Player
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

        public virtual string Position
        {
            get;
            set;
        }

        public virtual Team Team
        {
            get;
            set;
        }

        public virtual Person Person
        {
            get;
            set;
        }
    }
}
