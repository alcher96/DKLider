using DFKLider.Domains;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ParentsHomeController:Controller
    {
        private readonly DataManager dataManager;
        public ParentsHomeController(DataManager dataManager)
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
            return View(dataManager.Parents.GetParents());
        }

        //[HttpPost]
        //public IActionResult Delete(Guid id)
        //{
        //    dataManager.Students.DeleteStudent(id);
        //    return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        //}
    }
}

