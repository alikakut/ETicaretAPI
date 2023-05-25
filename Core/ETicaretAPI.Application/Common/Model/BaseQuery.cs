﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Common.Model
{
    public record BaseQuery
    {
        public long Id { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
