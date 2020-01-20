using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Entities;
using Crud.Handler;
using Microsoft.AspNetCore.Mvc;
using Crud.ModelHelper;
using Crud.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Crud.Controllers
{
    public class SimpleController : Controller
    {
        private readonly AppDbContext appDb;

        public SimpleController(AppDbContext appDb)
        {
            this.appDb = appDb;
        }
       
        public IActionResult Main()
        {
            List<CrudViewModel> models = new CrudDD(appDb).Get().ToModelList();
            return View(models);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return PartialView("~/Views/Simple/Create.cshtml");
        }
        [HttpPost]
        public IActionResult Create(CrudViewModel model)
        {
            new CrudDD(appDb).Add(model.ToEntity());

            return RedirectToAction("Main");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            CrudViewModel model = new CrudDD(appDb).Getone(id).ToModel();
            List<SelectListItem> items = new CrudDD(appDb).Get().ToSelectItemList();
            items.Find(x => Convert.ToInt32(x.Value) == model.Id).Selected = true;
            ViewBag.Cities = items;
            return PartialView("~/views/Simple/Edit.cshtml", model);
        }

        [HttpPost]
        public IActionResult Edit(CrudViewModel model)
        {
            new CrudDD(appDb).Update(model.Id, model.ToEntity());
            return RedirectToAction("Main");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            CrudViewModel model = new CrudDD(appDb).Getone(id).ToModel();
            return PartialView("~/views/Simple/delete.cshtml", model);
        }

        [HttpPost]
        public IActionResult Delete(CrudViewModel model)
        {
            new CrudDD(appDb).Delete(model.Id);
            return RedirectToAction("Main");
        }

        [HttpGet]
        public IActionResult Filter()
        {
            string key = Request.Query["key"];

            List<CrudViewModel> models = new CrudDD(appDb).Get().ToModelList();

            var result = (from m in models
                          where m.Name.StartsWith(key)
                          select m).ToList();
            return PartialView("~/views/Simple/_Filter.cshtml", result);
        }

    }
}