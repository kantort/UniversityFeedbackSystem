using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Diak : DIAKOK
    {
        public Diak()
        {

        }

        public Diak(int id, string azonosito)
        {
            this.AZONOSITO = azonosito;
            this.ID_DIAKOK = id;
        }
    }
}
