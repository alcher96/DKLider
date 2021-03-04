using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFKLider.Domains.Entities;

namespace DFKLider.Domains.Repositories.Abstract
{
    public interface IParentRepository
    {
        IQueryable<Parent> GetParents();
        Parent GetParentById(Guid id);
        void SaveParent(Parent entity);
        void DeleteParent(Guid id);
    }
}
