using sevimlidostlar.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevimlidostlar.BusinessLayer
{
   public class RepositoryBase  // her seferinde farklı context oluşturmamızın önüne gecerek ilşkili taploda insert etmek için 
    {
        private static DatabaseContext _db;
        private static object _lock = new object();
        protected RepositoryBase()
        {

        }
        public static DatabaseContext CreateContext()
        {
            if (_db ==null)
            {
                lock (_lock)
                {
                    if (_db == null)
                    {
                        _db = new DatabaseContext();
                    }
                    

                }

            }
            return _db;
        }
        
    }
}
