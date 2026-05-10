using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repos
{
    public class CategoryRepo
    {
        NLayerContext db_data;
        public CategoryRepo(NLayerContext db_data)
        {
            this.db_data = db_data;
        }
        public bool Create(Category C)
        {
            db_data.Categories.Add(C);
            return db_data.SaveChanges() > 0;
        }
        public List<Category> Get()
        {
            return db_data.Categories.ToList();
        }
        public Category Get(int id) {

            return db_data.Categories.Find(id);
        }
        public bool Update(Category C)
        {
            var exobj = Get(C.Id);
            db_data.Entry(exobj).CurrentValues.SetValues(C);
            return db_data.SaveChanges() > 0;
        }
        public bool Delete(int id) {
            var exobj = Get(id);
            db_data.Remove(exobj);
            return db_data.SaveChanges() > 0; 
        
        }


    }
}
