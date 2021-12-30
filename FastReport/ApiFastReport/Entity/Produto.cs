using ApiFastReport.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFastReport.Entity
{
    public class Produto : BaseEntity
    {
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Ean { get; set; }
        public int CategoriaId { get; set; }

        //EF
        public Categoria Categoria { get; set; }
    }
}
