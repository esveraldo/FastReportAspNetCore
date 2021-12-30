using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFastReport.Entity.Base
{
    public class BaseEntity
    {
        //public Guid Id { get; set; }

        //public BaseEntity()
        //{
        //    Id = Guid.NewGuid();
        //}

        [Key]
        public int Id { get; set; }

        private DateTime? _createdAt;

        public DateTime? CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value == null ? DateTime.Now : value; }
        }

        public DateTime? UpdatedAt { get; set; }
    }
}
