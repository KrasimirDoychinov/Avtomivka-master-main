namespace Avtomivka.A.Models.View
{
    using Avtomivka.A.Data.Models;
    using System.Collections.Generic;

    public class WorkersAllVM : BaseVM
    {
        public IEnumerable<Worker> Workers { get; set; }
    }
}
