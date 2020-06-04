using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PipsiProject.Models
{
    public class ImageModel
    {
        [Key]
        public int ImageId { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Nazwa fotki")]
        public string ImageTitle { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Wczytaj plik")]
        
        public IFormFile ImageFile { get; set; }

    }
}
