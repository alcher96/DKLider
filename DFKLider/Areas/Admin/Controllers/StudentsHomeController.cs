using DFKLider.Domains;
using DFKLider.Domains.Entities;
using DFKLider.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentsHomeController:Controller
    {
        private readonly DataManager dataManager;
        public StudentsHomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        //public IActionResult Edit(Guid id)
        //{
        //    var entity = id == default ? new Student() : dataManager.Students.GetStudentById(id);
        //    return View(entity);
        //}
        public IActionResult Index()
        {
            return View(dataManager.Students.GetStudents());
        }

        //[HttpPost]
        //public IActionResult Delete(Guid id)
        //{
        //    dataManager.Students.DeleteStudent(id);
        //    return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        //}
    }
}
