using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Demo_ModularLayer.DAL
{
    public class DBFactory
    {
         public IDatabase GetDatabase()
        {
            int dbchoice = Convert.ToInt32(ConfigurationManager.AppSettings["dbchoice"]);

            if(dbchoice == 1)
            {
                return new SQLServer();
            }

            else
            {
                return new Oracle();
            }
        }
    }
}
