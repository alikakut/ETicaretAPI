using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities
{
    [Table("customers")]
    public class Customer :BaseEntity
    {
        [Column("Name")]
        public string Name { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; } 
        //public ICollection<Order> Orders { get; set;}
    }
}
