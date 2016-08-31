using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorldNomads.Models
{
    public class TestModel
    {
        [Required]
        [Display(Name = "Input Number")]
        public string InputNumber { get; set; }

        public string Result { get; set; }
    }
}