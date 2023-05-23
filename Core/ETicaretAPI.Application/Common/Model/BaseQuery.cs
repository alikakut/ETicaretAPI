using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Common.Model
{
    public record BaseQuery
    {
        public int Id { get; set; }
        public string Page { get; set; }
        public string Size { get; set; }
    }
}
