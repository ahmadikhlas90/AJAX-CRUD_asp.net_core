using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Crud.Models;
using Docker.DotNet.Models;
using Microsoft.EntityFrameworkCore;
using Crud.Entities;

namespace Crud.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext context;

        public HomeController(ILogger<HomeController> logger,AppDbContext context)
        {
            _logger = logger;
            //this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult CrudMainPage()
        {

            return View();
        }

        //public JsonResult SaveAndUpdateProduct(int PID, string Name, string fatherName, string location, string CNIC, int age)
        //{
        //    var result = new JSONMessage();
        //    try
        //    {
        //        //define the model  
        //        CrudOperations crd = new CrudOperations();
        //        crd.Id = PID;
        //        crd.Name = Name;
        //        crd.FatherName = fatherName;
        //        crd.Age = age;
        //        crd.CNIC = CNIC;
        //        crd.Location = location;


        //        //for insert recored..  
        //        if (crd.Id == 0)
        //        {
        //            context.firstCrud.Add(crd);
        //            result.Message = "your product has been saved success..";
        //            result.Status = true;
        //        }
        //        else  //for update recored..  
        //        {
        //            context.Entry(crd).State = EntityState.Modified;
        //            result.Message = "your product has been updated successfully..";
        //            result.Status = true;
        //        }
        //        context.SaveChanges();


        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorLogers.ErrorLog(ex);
        //        result.Message = "We are unable to process your request at this time. Please try again later.";
        //        result.Status = false;
        //    }
        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}


        //public JsonResult GetProduct()
        //{

        //    List<CrudViewModel> _list = new List<CrudViewModel>();

        //    try
        //    {
        //        _list = context.firstCrud.ToList();
        //        var result = from c in _list
        //                     select new[]
        //                     {
        //                  Convert.ToString( c.Id ),  // 0     
        //                  Convert.ToString( c.Name ),  // 1     
        //                  Convert.ToString( c.FatherName ),  // 2     
        //                  Convert.ToString( c.CNIC ),  // 3     
        //                  Convert.ToString( c.Location ),  // 4     
        //                  Convert.ToString( c.Age ),  // 
        //                                           };

        //        return Json(new
        //        {
        //            aaData = result
        //        }, JsonRequestBehavior.AllowGet);
        //    }

        //    catch (Exception ex)
        //    {
        //        ErrorLogers.ErrorLog(ex);
        //        return Json(new
        //        {
        //            aaData = new List<string[]> { }
        //        }, JsonRequestBehavior.AllowGet);
        //    }

        //}
        //public JsonResult DeleteProduct(int id)
        //{
        //    var result = new jsonMessage();
        //    try
        //    {

        //        var product = new Mst_Product { PID = id };
        //        context.Entry(product).State = EntityState.Deleted;
        //        context.SaveChanges();


        //        result.Message = "your product has been deleted successfully..";
        //        result.Status = true;

        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorLogers.ErrorLog(ex);
        //        result.Message = "We are unable to process your request at this time. Please try again later.";
        //        result.Status = false;
        //    }
        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}
    }
}
