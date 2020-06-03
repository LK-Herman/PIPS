using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace PipsiProject.Models
{
    public class CarColor
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public Color Kolor { get; set; }
    }

    
}
