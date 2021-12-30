using ApiFastReport.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFastReport.Entity
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        //EF
        public IEnumerable<Venda> Vendas { get; set; }
    }
}
