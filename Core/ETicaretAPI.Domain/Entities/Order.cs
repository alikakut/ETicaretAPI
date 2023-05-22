using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain.Entities
{
    public class Order :BaseEntity
    {
        [Column("Description")]
        public string Description { get; set; }

        [Column("Address")]
        public string Address { get; set; }
       // public ICollection<Product>? Products { get; set; }
        public Customer? Customer { get; set; }
    }
}
