using customVlidatorProject.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace customVlidatorProject.Controllers
{
    public class HomeController : Controller
    {

       public static  List<DateValidationClass> list = new List<DateValidationClass>();
       //public static dynamic mymodel = new ExpandoObject();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        [HttpGet]
        public ActionResult DateValidatorView()
        {
            return View("DateValidatorView");
        }

        [HttpPost]
        public ActionResult DateValidatorView([ModelBinder(typeof(ModelBinderClass))]DateValidationClass obj){

            if (ModelState.IsValid)
            {
                // SAVE TO DATABASE
                list.Add(obj);

                // CALL GOOGLE API
            }

            System.Threading.Thread.Sleep(2000);
            return PartialView("_myPartialView",list);
        }


        /*
        [ChildActionOnly]
        public ActionResult myPartialView()
        {
            return PartialView(list);
        }
        */
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            base.OnActionExecuting(filterContext);

           filterContext.HttpContext.Trace.Write("Log: OnActionExecuting","Calling" +filterContext.ActionDescriptor.ActionName);

        }



    }
}