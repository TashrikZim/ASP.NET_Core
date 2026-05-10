using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class ProductRepo
    {

        NLayerContext db_data;
        public ProductRepo(NLayerContext db_data)
        {
            this.db_data = db_data;
        }
        public bool Create(Product C)
        {
            db_data.Products.Add(C);
            return db_data.SaveChanges() > 0;
        }
        public List<Product> Get()
        {
            return db_data.Products.ToList();
        }
        public Product Get(int id)
        {

            return db_data.Products.Find(id);
        }
        public bool Update(Product C)
        {
            var exobj = Get(C.Id);
            db_data.Entry(exobj).CurrentValues.SetValues(C);
            return db_data.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var exobj = Get(id);
            db_data.Remove(exobj);
            return db_data.SaveChanges() > 0;

        }


    }
}
