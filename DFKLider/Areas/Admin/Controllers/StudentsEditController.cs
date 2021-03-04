using DFKLider.Domains;
using DFKLider.Domains.Entities;
using DFKLider.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentsEditController:Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public StudentsEditController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Student() : dataManager.Students.GetStudentById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Student model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                //TODO add image to Model

                //if (titleImageFile != null)
                //{
                //    model.TitleImagePath = titleImageFile.FileName;
                //    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                //    {
                //        titleImageFile.CopyTo(stream);
                //    }
                //}
                dataManager.Students.SaveStudent(model);
                return RedirectToAction(nameof(StudentsHomeController.Index), nameof(StudentsHomeController).CutController());
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Students.DeleteStudent(id);
            return RedirectToAction(nameof(StudentsHomeController.Index), nameof(StudentsHomeController).CutController());
        }
    }
}
