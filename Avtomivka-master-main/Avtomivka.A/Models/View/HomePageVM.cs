namespace Avtomivka.A.Models.View
{
    using Avtomivka.A.Data.Models;
    using System.Collections.Generic;
    public class HomePageVM : BaseVM
    {
        public IEnumerable<Colon> Colons { get; set; }
    }
}
