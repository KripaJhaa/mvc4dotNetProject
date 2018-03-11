using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace customVlidatorProject.Models
{
    public class ModelBinderClass : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType == typeof(DateValidationClass))
            {
                HttpRequestBase request = controllerContext.HttpContext.Request;

                DateTime startDate = Convert.ToDateTime( request.Form.Get("StartDate"));
                DateTime endDate = Convert.ToDateTime(request.Form.Get("EndDate"));

                startDate=startDate.AddDays(1);
                return new DateValidationClass
                {
                    StartDate = startDate,
                    EndDate = endDate
                };

            }

            //// call the default model binder this new binding context
            //return base.BindModel(controllerContext, newBindingContext);
            else
            {
                return base.BindModel(controllerContext, bindingContext);
            }
        }

    }
}