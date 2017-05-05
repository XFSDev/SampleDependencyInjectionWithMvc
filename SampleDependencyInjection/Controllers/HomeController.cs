using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleDependencyInjection.Models;

namespace SampleDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        readonly IProductRepository _repository;

        public HomeController(IProductRepository repository)
        {
            this._repository = repository;
        }

        public ActionResult Index()
        {
            var resultSet = _repository.GetAll();

            return View();
        }

    }
}
