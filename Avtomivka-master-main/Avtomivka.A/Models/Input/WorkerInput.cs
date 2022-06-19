namespace Avtomivka.A.Models.Input
{
    using Avtomivka.A.Models.View;
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;
    public class WorkerInput : BaseVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(20, 70)]
        public int Age { get; set; }

        [Required]
        public IFormFile Image { get; set; }

        [Required]
        public string Description { get; set; }

        public bool Taken { get; set; }
    }
}
