using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFKLider.Domains.Repositories.Abstract;

namespace DFKLider.Domains
{
    public class DataManager
    {
        public ICoachRepository Coaches { get; set; }
        public IGroupRepository Groups { get; set; }
        public IParentRepository Parents { get; set; }
        public IStudentRepository Students { get; set; }

        public DataManager(ICoachRepository coaches, IGroupRepository groups, IParentRepository parents, IStudentRepository students)
        {
            Coaches = coaches;
            Groups = groups;
            Parents = parents;
            Students = students;
        }
    }
}
