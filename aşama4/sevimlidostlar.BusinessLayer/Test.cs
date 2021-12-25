using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevimlidostlar.BusinessLayer
{
   public class Test
    {
        public Test()
        {
            dataAccessLayer.DatabaseContext db = new dataAccessLayer.DatabaseContext();
            db.SevimlidostlarUsers.ToList();
        }
    }
}
