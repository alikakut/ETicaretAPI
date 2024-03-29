﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities.Common
{
    public class BaseEntity
    {
        [Column("Id")]
        [Key()]
        public int Id { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [Column("UpdateBy")]
        public string? UpdateBy { get; set; }

        [Column("UpdateDate")]
        public DateTime UpdateDate { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }=false;

    }
}
