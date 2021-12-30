using ApiFastReport.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFastReport.Entity
{
    public class Venda : BaseEntity
    {
        public DateTime DataDaVenda { get; set; }
        public decimal TotalDaVenda { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        //EF
        public IEnumerable<VendaItem> VendaItems { get; set; }
    }
}
