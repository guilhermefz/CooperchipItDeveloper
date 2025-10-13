using Cooperchip.ItDeveloper.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperchipItDeveloper.Domain.Entities
{
    public class Cid : EntityBase
    {
        public int CidInternalId { get; set; }
        public string Codigo { get; set; }
        public string Diagnostico { get; set; }
    }
}
