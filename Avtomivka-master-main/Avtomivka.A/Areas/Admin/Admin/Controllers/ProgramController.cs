namespace Avtomivka.A.Areas.Administration.Administration.Controllers
{
    using Avtomivka.A.Logic.Interface;
    using Avtomivka.A.Models.Input;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProgramController : Controller
    {
        private readonly IProgramServices programServices;

        public ProgramController(IProgramServices programServices)
        {
            this.programServices = programServices;
        }

        public IActionResult Programs()
        {
            var programs = this.programServices.All();
            return this.View(programs);
        }

        public IActionResult CreateProgram()
        {
            return this.View(new ProgramInput());
        }

        [HttpPost]
        public async Task<IActionResult> CreateProgram(ProgramInput input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.programServices.Create(input.Name, input.Price, input.Description);
            return this.RedirectToAction("Programs");
        }

        public IActionResult EditProgram(string id)
        {
            var program = this.programServices.ById(id);
            var model = new ProgramInput
            {
                Name = program.Name,
                Description = program.Description,
                Price = program.Price,
                Id = program.Id
            };

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditProgram(ProgramInput input)
        {
            if (!ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.programServices.Update(input.Id, input.Name, input.Price, input.Description);
            return this.RedirectToAction(nameof(Programs));
        }

        public async Task<IActionResult> DeleteProgram(string id)
        {
            await this.programServices.Delete(id, "Program");
            return this.RedirectToAction("Programs");
        }
    }
}
