using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Kar : KAROK
    {
        public Kar()
        {

        }

        public Kar(int id, string nev)
        {
            this.ID_KAROK = id;
            this.NEV = nev;
        }
    }
}
