using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MaxiTorneo.Entities
{
    public partial class Person
    {
        [Key]
        public string Name 
        {
            get;
            set;
        }

        public virtual Team Team
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
