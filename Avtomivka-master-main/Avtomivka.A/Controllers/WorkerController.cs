namespace Avtomivka.A.Controllers
{
    using Avtomivka.A.Logic.Interface;
    using Microsoft.AspNetCore.Mvc;

    public class WorkerController : Controller
    {
        private readonly IWorkerServices workerServices;

        public WorkerController(IWorkerServices workerServices)
        {
            this.workerServices = workerServices;
        }

        public JsonResult GetImage(string id)
        {
            var workerImage = this.workerServices.ById(id)?.Image;
            return this.Json(new { workerImage });
        }
    }
}
