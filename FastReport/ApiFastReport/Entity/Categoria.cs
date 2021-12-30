using ApiFastReport.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFastReport.Entity
{
    public class Categoria : BaseEntity
    {
        public string Descricao { get; set; }

        //EF
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
