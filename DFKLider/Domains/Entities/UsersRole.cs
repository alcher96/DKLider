using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Domains.Entities
{
    public class UsersRole
    {
        public Guid Id { get; set; }
        public string AdminRole { get; set; } = "ADMIN";
        public string StudentRole { get; set;} = "STUDENT";
        public string ParentRole { get; set;} = "PARENT";
        public string CoachRole { get; set;} = "COACH";
    }
}
