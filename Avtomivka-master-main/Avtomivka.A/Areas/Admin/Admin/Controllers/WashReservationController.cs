using Avtomivka.A.Logic.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avtomivka.A.Areas.Admin.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class WashReservationController : Controller
    {
        private readonly IWashReservationServices washReservationServices;

        public WashReservationController(IWashReservationServices washReservationServices)
        {
            this.washReservationServices = washReservationServices;
        }

        public IActionResult WashReservations()
        {
            var reservations = this.washReservationServices.All();
            return this.View(reservations);
        }
    }
}
