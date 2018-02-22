using MarketDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketBLL.Repository
{
   public class RepositoryBase<T,ID> where T:class
    {
        protected internal static MarketContext dbContext; //bulunduğu projeden erişilir.Bulunduğu projeden kalıtım alırsa kullanabilir.
        public virtual List<T> GetAll()
        {
            try
            {
                dbContext = new MarketContext();
                return dbContext.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual T GetByID(ID id)
        {
            try
            {
                dbContext = new MarketContext();
                return dbContext.Set<T>().Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual void Insert(T entity) //T model
        {
            try
            {
                dbContext = dbContext ?? new MarketContext();
                dbContext.Set<T>().Add(entity);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public virtual void Delete(T entity)
        {
            try
            {
                dbContext = dbContext ?? new MarketContext();
                dbContext.Set<T>().Remove(entity);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual void Update()
        {
            try
            {
                dbContext = dbContext ?? new MarketContext();
                dbContext.SaveChanges(); //GetByID ile ürünü başka yerlerde çekip REFERANSTAN değişir. Sonra orada değişiklikleri yap. Sonra sadece update etmen gerekir.
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        }
    }
