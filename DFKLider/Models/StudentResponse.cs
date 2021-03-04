using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Models
{
    public class StudentResponse
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime Burthday { get; set; }
    }
}
