namespace Avtomivka.A.Controllers
{
    using Avtomivka.A.Data;
    using Avtomivka.A.Logic.Interface;
    using Avtomivka.A.Models;
    using Avtomivka.A.Models.View;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IColonServices colonServices;
        private readonly IProgramServices programServices;
        private readonly IWashReservationServices washReservationServices;
        private readonly IWorkerServices workerServices;

        public HomeController(ILogger<HomeController> logger, 
            IColonServices colonServices,
            IProgramServices programServices,
            IWashReservationServices washReservationServices, IWorkerServices workerServices)
        {
            _logger = logger;
            this.colonServices = colonServices;
            this.programServices = programServices;
            this.washReservationServices = washReservationServices;
            this.workerServices = workerServices;
        }

        public IActionResult Index()
        {
            var vm = new HomePageVM
            {
                Colons = this.colonServices.All()
                .Where(x => !x.Delete)
                .OrderBy(x => x.Number)
            };

            return View(vm);
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
    }
}
