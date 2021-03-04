using DFKLider.Domains.Entities;
using DFKLider.Domains.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Domains.Repositories.EntityFramework
{
    public class EFStudentRepository : IStudentRepository
    {
        private readonly AppDbContext context;

        public EFStudentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Student> GetStudents()
        {
            return context.Students;
        }
        public Student GetStudentById(Guid id)
        {
            return context.Students.FirstOrDefault(x => x.Id == id);
        }
        public void SaveStudent(Student entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteStudent(Guid id)
        {
            context.Students.Remove(new Student() { Id = id });
            context.SaveChanges();
        } 
    }
}
