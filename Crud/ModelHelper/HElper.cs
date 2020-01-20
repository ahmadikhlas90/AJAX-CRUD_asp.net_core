using Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Crud.ModelHelper
{
    public static class HElper
    {
        #region //   main Interface List
        public static List<SelectListItem> ToSelectItemList(this IEnumerable<IListable> entitiesList)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var entity in entitiesList)
            {
                items.Add(new SelectListItem { Text = entity.Name, Value = Convert.ToString(entity.Id) });
            }
            items.TrimExcess();
            return items;
        }
        #endregion
        public static CrudOperations ToEntity(this CrudViewModel model)
        {
            return new CrudOperations { Id = model.Id, Name = model.Name, Age = model.Age, Location=model.Location,CNIC=model.CNIC,FatherName=model.FatherName };
        }
        public static CrudViewModel ToModel(this CrudOperations entity)
        {
            return new CrudViewModel { Id = entity.Id, Name = entity.Name,FatherName=entity.FatherName,CNIC=entity.CNIC,Age=entity.Age,Location=entity.Location };
        }
        public static List<CrudViewModel> ToModelList(this List<CrudOperations> entitiesList)
        {
            List<CrudViewModel> modelsList = new List<CrudViewModel>();
            foreach (var entity in entitiesList)
            {
                modelsList.Add(entity.ToModel());
            }
            modelsList.TrimExcess();
            return modelsList;
        }
    }
}
