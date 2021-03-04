using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Domains.Entities
{
    public class Coach:EntityBase
    {
        [Required]
        public Guid Id { get; set; }

        //TODO изменить тип данных на date
        [Display(Name = "Дата рождения тренера")]
        public DateTime Burthday { get; set; }

        [Display(Name = "Образование тренера")]
        public string Education { get; set; }

        [Display(Name = "Контактный телефон тренера")]
        public string Phone { get; set; }
        public virtual ICollection<Group> Groups { get; set; }

    }
}
