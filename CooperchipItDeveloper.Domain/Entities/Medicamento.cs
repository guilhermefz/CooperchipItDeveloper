using Cooperchip.ItDeveloper.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperchipItDeveloper.Domain.Entities
{
    public class Medicamento : EntityBase
    {
        public Medicamento() { }

        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Generico { get; set; }
        public int CodigoGenerico { get; set; }
    }
}
