using sevimlidostlar.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace sevimlidostlar.BusinessLayer
{
   public  class Repository<T> where T:class
    {
        private DatabaseContext db;
       
        private DbSet<T> _objectSet;

        public Repository()
        {
            db = RepositoryBase.CreateContext();
            _objectSet = db.Set<T>();
        }

        //listelemek için 
        public List<T> List()
        {
            return _objectSet.ToList();

        }
        //girilen koşula göre listeleme
        public List<T> List(Expression<Func<T,bool>> where)
        {
            return _objectSet.Where(where).ToList();

        }
        //ekleme
        public int Insert (T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }
        //güncellemek
        public int Update()
        {
            return Save();
        }
        //silme
        public int Delete(T obj )
        {
            _objectSet.Remove(obj);
            return Save();

               
        }
        //tek kayıt getirir
        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }
        //save etme
        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
