using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Types;

namespace DataAccessLayer
{
    public class Kerdes : KERDESEK
    {
        public Kerdes()
        {

        }

        public Kerdes(int id)
        {
            this.ID_KERDESEK = id;
            
        }   
    }
}
