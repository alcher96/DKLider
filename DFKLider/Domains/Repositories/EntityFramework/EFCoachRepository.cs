using DFKLider.Domains.Entities;
using DFKLider.Domains.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Domains.Repositories.EntityFramework
{
    public class EFCoachRepository : ICoachRepository
    {
        private readonly AppDbContext context;
        public EFCoachRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Coach> GetCoaches()
        {
            return context.Coaches;
        }

        public Coach GetCoachById(Guid id)
        {
            return context.Coaches.FirstOrDefault(x => x.Id == id);
        }

        public void ChangeGroups(Guid id, Guid coachId)
        {
            
            Group groups = context.Groups.Where(c => c.Id == id).FirstOrDefault();
            Coach coach = context.Coaches.Where(c => c.Id == coachId).FirstOrDefault();
            groups.Coach = coach;
            context.Update(groups);
            context.Entry(groups).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void SaveCoach(Coach entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
            {

                entity = context.Coaches.Where(c => c.Id == entity.Id).FirstOrDefault();
                Group group = context.Groups.Where(c => c.CoachId == entity.Id).FirstOrDefault();
                group.CoachId = entity.Id;

                context.Entry(entity).State = EntityState.Modified;
            }
                
            context.SaveChanges();
        }

        public void DeleteCoach(Guid id)
        {
            context.Coaches.Remove(new Coach() { Id = id });
            context.SaveChanges();
        }

    }
}
