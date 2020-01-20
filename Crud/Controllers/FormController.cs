using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Handler;
using Crud.ModelHelper;
using Crud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Crud.Controllers
{
    public class FormController : Controller
    {
        private readonly AppDbContext appDb;

        public FormController(AppDbContext appDb)
        {
            this.appDb = appDb;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<CrudViewModel> models = new CrudDD(appDb).Get().ToModelList();
            ViewBag.item = models;

            return View();
        }
        [HttpPost]
        public IActionResult Index(CrudViewModel model)
        {
            if(model.Id == 0)
            {
                new CrudDD(appDb).Add(model.ToEntity());
            }
            else
            {
                new CrudDD(appDb).Update(model.Id,model.ToEntity());
            }
            var res = GetList();
            return res;
        }
    
        [HttpGet]
        public IActionResult GetList()
        {
            List<CrudViewModel> models = new CrudDD(appDb).Get().ToModelList();
            ViewBag.item = models;
            return PartialView("~/views/Form/GetList.cshtml");
        }

        public IActionResult Delete(int id)
        {
            new CrudDD(appDb).Delete(id).ToModel();
            var res = GetList();
            return res;
        }
  
        public IActionResult EditRecode(int id)
        {
            CrudViewModel model = new CrudDD(appDb).Getone(id).ToModel();
            return Json(new {name=model.Name,fatherName=model.FatherName,id=model.Id,age=model.Age,location=model.Location,cnic=model.CNIC });
        }

    }
}