using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PipsiProject.Models
{
    public class CarMark
    {
        [Key]
        public int Id { get; set; }
        public string Marka { get; set; }
    }
}
