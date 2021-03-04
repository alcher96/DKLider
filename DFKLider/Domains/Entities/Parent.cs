using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Domains.Entities
{
    public class Parent:EntityBase
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Контактный телефон родителя")]
        public string Phone { get; set; }

        [Display(Name = "Статус оплаты")]
        public bool Payment { get; set; }
        public IList<Student> Students { get; set; }

    }
}
