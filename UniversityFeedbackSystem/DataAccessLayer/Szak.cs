using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Szak : SZAKOK
    {
        public Szak()
        {

        }

        public Szak(int id, string nev)
        {
            this.ID_SZAKOK = id;
            this.NEV = nev;
        }
    }
}
