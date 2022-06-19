namespace Avtomivka.A.Areas.Administration.Administration.Controllers
{
    using Avtomivka.A.Data;
    using Avtomivka.A.Logic.Interface;
    using Avtomivka.A.Models.Input;
    using Avtomivka.A.Models.View;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System.IO;
    using System.Threading.Tasks;

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class WorkerController : Controller
    {
        private readonly IWorkerServices workerServices;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ApplicationDbContext context;

        public WorkerController(IWorkerServices workerServices, IWebHostEnvironment webHostEnvironment, 
            ApplicationDbContext context)
        {
            this.workerServices = workerServices;
            this.webHostEnvironment = webHostEnvironment;
            this.context = context;
        }

        public IActionResult Workers()
        {
            var vm = new WorkersAllVM
            {
                Workers = this.workerServices.All()
            };

            return this.View(vm);
        }

        public IActionResult CreateWorker()
            => this.View(new WorkerInput());

        [HttpPost]
        public async Task<IActionResult> CreateWorker(WorkerInput input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            var id = await this.workerServices.Create(input.Name, input.Age, input.Image.FileName, input.Description);
            await this.UpdateImage(this.webHostEnvironment.WebRootPath, id, input.Image);
            return this.RedirectToAction("Workers");
        }

        public IActionResult InfoWorker(string id)
        {
            var worker = this.workerServices.ById(id);
            var vm = new WorkerVM
            {
                Age = worker.Age,
                Name = worker.Name,
                Description = worker.Description,
                Id = worker.Id,
                Image = worker.Image,
                Taken = worker.Taken
            };

            return this.View(vm);
        }

        public IActionResult EditWorker(string id)
        {
            var worker = this.workerServices.ById(id);
            var vm = new WorkerInput
            {
                Age = worker.Age,
                Name = worker.Name,
                Description = worker.Description,
                Id = worker.Id,
                Taken = worker.Taken
            };

            return this.View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> EditWorker(WorkerInput input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.workerServices.Update(input.Id, input.Name, input.Age, input.Image.FileName, input.Description);
            await this.UpdateImage(this.webHostEnvironment.WebRootPath, input.Id, input.Image);
            return this.RedirectToAction("Workers");
        }

        public async Task<IActionResult> DeleteWorker(string id)
        {
            await this.workerServices.Delete(id, "Worker");
            return this.RedirectToAction("Workers");
        }

        private async Task UpdateImage(string webRootPath, string id, IFormFile image)
        {
            var worker = this.workerServices.ById(id);
            worker.Image = $"{id}.png";

            using (var fs = new FileStream(
               $"{webRootPath}/Images/{worker.Image}", FileMode.Create))
            {
                await image.CopyToAsync(fs);
            }


            await this.context.SaveChangesAsync();
        }
    }
}
