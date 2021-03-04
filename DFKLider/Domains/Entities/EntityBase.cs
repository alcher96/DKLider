using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Domains.Entities
{
    public class EntityBase
    {
        [Display(Name = "Имя тренера")]
        public string Name { get; set; }

        [Display(Name = "Фамилия тренера")]
        public string SurName { get; set; }

        [Display(Name = "Отчество тренера")]
        public string MiddleName { get; set; }

        [Display(Name = "Тренер")]
        public string FullName => $"{Name} {SurName} {MiddleName}";


    }
}
