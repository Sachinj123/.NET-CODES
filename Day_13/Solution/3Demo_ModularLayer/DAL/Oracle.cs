using _3Demo_ModularLayer.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3Demo_ModularLayer.DAL
{
    public class Oracle:IDatabase
    {
        public List<Emp> Select()
        {
            return null;
        }

        public int Insert(Emp emp)
        {
            return 0;
        }

        public int Update(Emp emp)
        {
            return 0;
        }

        public int Delete(Emp emp)
        {
            return 0;
        }
    }
}
