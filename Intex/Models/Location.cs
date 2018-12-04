﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    [Table("Location")]
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        public string Description { get; set; }
    }
}