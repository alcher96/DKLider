using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Domains.Entities
{
    public class Group
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Номер группы")]
        public string GroupNumber { get; set; }
        public IList<Student> Students { get; set; }
        public Guid? CoachId { get; set; }
        public virtual Coach Coach { get; set; }
    }
}
