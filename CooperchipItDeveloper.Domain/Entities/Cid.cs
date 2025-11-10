using Cooperchip.ItDeveloper.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooperchipItDeveloper.Domain.Entities
{
    public class Cid : EntityBase
    {
        [Display(Name = "Internal ID")]
        [Required(ErrorMessage = "Internal ID é obrigatório")]
        public int CidInternalId { get; set; }

        [Required(ErrorMessage = "Código é obrigatório")]
        [Display(Name = "Código")]
        [MaxLength(6)]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Diagnóstico é obrigatório")]
        [Display(Name = "Diagnóstico")]
        [MaxLength(4000)]
        public string Diagnostico { get; set; }
    }
}
