using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Domains.Entities
{
    public class Student:EntityBase
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Дата рождения ученика")]
        public DateTime Burthday { get; set; }

        [Display(Name = "Дата страхования ученика")]
        public DateTime InsuranceDate { get; set; }

        [Display(Name = "Дата получения ученика справки от педиатра")]
        public DateTime DoctorNoteData { get; set; }

        [Display(Name = "Многодетность ученика")]
        public bool ManyChildren { get; set; }

        [Display(Name = "Место проведения тренировок ученика")]
        public string TrainingLocation { get; set; }

        [Display(Name = "Достижения ученика")]
        public string Records { get; set; }
        public Guid? GroupId { get; set; }
        public Group Groups { get; set; }

        public Guid? ParentId { get; set; }
        public Parent Parents { get; set; }

        //TODO add login and pass fields
    }
}
