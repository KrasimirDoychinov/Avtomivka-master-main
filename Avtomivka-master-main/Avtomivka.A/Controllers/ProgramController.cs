namespace Avtomivka.A.Controllers
{
    using Avtomivka.A.Logic.Interface;
    using Microsoft.AspNetCore.Mvc;

    public class ProgramController : Controller
    {
        private readonly IProgramServices programServices;

        public ProgramController(IProgramServices programServices)
        {
            this.programServices = programServices;
        }

        public JsonResult GetDescription(string id)
        {
            if (id != null)
            {
                var description = this.programServices.ById(id)?.Description;
                return this.Json(new { description });
            }
            return this.Json(new { });
        }
    }
}
