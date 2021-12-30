using ApiFastReport.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFastReport.Entity
{
    public class VendaItem : BaseEntity
    {
        public decimal Quantidade { get; set; }
        public decimal ValorProduto { get; set; }
        public decimal TotalProduto { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }

        //EF
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
    }
}
