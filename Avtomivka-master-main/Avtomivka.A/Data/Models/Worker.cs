namespace Avtomivka.A.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Worker : BaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        public string Image { get; set; }

        [Required]
        public string Description { get; set; }

        public bool Taken { get; set; }
    }
}
