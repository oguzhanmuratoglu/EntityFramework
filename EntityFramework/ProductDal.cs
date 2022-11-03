using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContex contex = new ETradeContex())
            {
                return contex.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (ETradeContex contex = new ETradeContex())
            {
                //contex.Products.Add(product);
                var entity = contex.Entry(product);
                entity.State = EntityState.Added;
                contex.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContex contex = new ETradeContex())
            {
                
                var entity = contex.Entry(product);
                entity.State = EntityState.Modified;
                contex.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContex contex = new ETradeContex())
            {

                var entity = contex.Entry(product);
                entity.State = EntityState.Deleted;
                contex.SaveChanges();
            }
        }
    }
}
