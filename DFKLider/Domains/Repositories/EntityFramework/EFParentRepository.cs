using DFKLider.Domains.Entities;
using DFKLider.Domains.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Domains.Repositories.EntityFramework
{
    public class EFParentRepository : IParentRepository
    {
        private readonly AppDbContext context;

        public EFParentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Parent> GetParents()
        {
            return context.Parents;
        }
        public Parent GetParentById(Guid id)
        {
            return context.Parents.FirstOrDefault(x => x.Id == id);
        }
        public void SaveParent(Parent entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteParent(Guid id)
        {
            context.Parents.Remove(new Parent() { Id = id });
            context.SaveChanges();
        }
    }
}
