using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IGotThisShit.Objects.ViewModels;
using IGotThisShit.Service.Providers;

namespace IGotThisShit.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataProvider _homeProvider;

        public HomeController(IDataProvider homeProvider)
        {
            _homeProvider = homeProvider;
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(_homeProvider.GetData());
        }

    }
}
