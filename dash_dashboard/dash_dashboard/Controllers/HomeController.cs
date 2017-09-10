using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dash_dashboard.Service;
using dash_dashboard.ViewModel;

namespace dash_dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISystemService _systemService;

        public HomeController(ISystemService systemService)
        {
            _systemService = systemService;
        }

        public IActionResult Index()
        {
            var process = _systemService.getProcessInfo();
            var disk = _systemService.getDiskUsage();

            var model = new DashboardViewModel()
            {
                Process = process,
                Disk = disk
            };

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
