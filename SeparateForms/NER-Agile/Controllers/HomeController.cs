using BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NER_Agile.Models;
using System;
using System.Diagnostics;

namespace NER_Agile.Controllers
{
    public class HomeController : Controller
    {

        IInstallationManager InstallationManager { get; }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IInstallationManager installationManager)
        {
            _logger = logger;
            InstallationManager = installationManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Add()
        {

            return View();
        }

        public IActionResult AddInstallation(String Street, int Number, String City, int Postcode, String Energy, String Integration, String PVCells, double FieldOrientation, double SlopRoof, double Length, double Width, double Area)
        {
            int id = InstallationManager.AddInstallation(Street, Number, Postcode, City, Energy, Integration, PVCells, FieldOrientation, SlopRoof, Length, Width, Area);
            return View("SaveResultView", id);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
