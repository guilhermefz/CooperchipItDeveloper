using Cooperchip.ItDeveloper.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperchipItDeveloper.Domain.Entities
{
    public class Generico : EntityBase
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Generico() { }
    }
}
