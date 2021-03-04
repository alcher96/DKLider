using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFKLider.Domains.Entities;

namespace DFKLider.Domains.Repositories.Abstract
{
    public interface IStudentRepository
    {
        IQueryable<Student> GetStudents();
        Student GetStudentById(Guid id);
        void SaveStudent(Student entity);
        void DeleteStudent(Guid id);
    }
}
