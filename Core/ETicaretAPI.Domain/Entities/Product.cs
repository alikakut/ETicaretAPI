using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities
{
    [Table("Product")]
    public class Product :BaseEntity
    {
        [Column("Name")]
        public string Name { get; set; }

        [Column("Price")]
        public float Price { get; set; }

        [Column("Stock")]
        public int Stock { get; set; }  
        //public ICollection<Order> Orders { get; set; }
    }
}
