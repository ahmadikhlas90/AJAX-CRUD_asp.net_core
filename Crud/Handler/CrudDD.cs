using Crud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Handler
{
    public class CrudDD
    {
        private readonly AppDbContext context;

        //Country
        public CrudDD( AppDbContext context)
        {
            this.context = context;
        }
        public CrudOperations Add(CrudOperations entity)
        {
                context.Add(entity);
                context.SaveChanges();
            return entity;
        }
        public CrudOperations Delete(int idToSearch)
        {
            CrudOperations found = null;
                found = context.Find<CrudOperations>(idToSearch);
                context.Remove(found);
                context.SaveChanges();
            return found;
        }
        public CrudOperations Update(int idToSearch, CrudOperations entity)
        {
            CrudOperations found = null;
                found = context.Find<CrudOperations>(idToSearch);
                if ( entity.Age != 0)
                {
                    found.Age = entity.Age;
                }
                if (!string.IsNullOrEmpty(entity.Name))
                {
                    found.Name = entity.Name;
                } 
            if (!string.IsNullOrEmpty(entity.FatherName))
                {
                    found.FatherName = entity.FatherName;
                }
            if (!string.IsNullOrEmpty(entity.Location))
                {
                    found.Location = entity.Location;
                }  
            if (!string.IsNullOrEmpty(entity.CNIC))
                {
                    found.CNIC = entity.CNIC;
                }
                context.SaveChanges();
            return entity;
        }
        public List<CrudOperations> Get()
        {
                return (from c in context.firstCrud
                        select c).ToList();
        }
        public CrudOperations Getone(int id)
        {
                return (from c in context.firstCrud
                        where c.Id == id
                        select c).FirstOrDefault();
        }

    }
}
