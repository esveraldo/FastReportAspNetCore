using ApiFastReport.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFastReport.Entity
{
    public class Empresa : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }
    }
}
