using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3Demo_ModularLayer.POCO;

namespace _3Demo_ModularLayer.DAL
{
    public interface IDatabase
    {
        List<Emp> Select();

        int Insert(Emp emp);

        int Update(Emp emp);

        int Delete(Emp emp);
    }
}
