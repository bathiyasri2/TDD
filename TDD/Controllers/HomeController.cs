using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDD.Repositiry;

namespace TDD.Controllers
{
    public class HomeController : Controller
    {
        IContactRepository _repository;
        public HomeController() :this(new EfContactReporsitory())
        {
        
        }
       public  HomeController(IContactRepository reppositiry)
        {
            _repository = reppositiry;
        }


        public ActionResult Index()
        {
             return View("Index", _repository.GetAllContacts());
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ViewResult Create()
        {
            return View("Create", new Contact());
        }
        [HttpPost]
        public ViewResult Create(Contact model)
        {
            _repository.CreateNewContact(model);
            return View("Create", model);
        }

    }
}