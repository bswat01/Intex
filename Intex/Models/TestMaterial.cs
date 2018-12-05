using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Intex.Models
{
    public class TestMaterial
    {
        public Test Tests { get; set; }
        public Material Materials { get; set; }
    }
}