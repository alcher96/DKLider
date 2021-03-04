using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFKLider.Domains.Entities;

namespace DFKLider.Domains.Repositories.Abstract
{
    public interface ICoachRepository
    {
        IQueryable<Coach> GetCoaches();
        Coach GetCoachById(Guid id);

        void ChangeGroups(Guid id, Guid coachId);
        void SaveCoach(Coach entity);
        void DeleteCoach(Guid id);
    }
}
