using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace PipsiProject.Models
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marka { get; set; }
        [Required]
        public string Model { get; set; }
        public string Klasa { get; set; }
        [DisplayName("Pojemność skokowa (cm3)")]
        public int PojSilnika { get; set; }
        [DisplayName("Przebieg (km)")]
        public double Przebieg { get; set; }
        [DisplayName("Rok produkcji")]
        public DateTime RokProd { get; set; }
        [DisplayName("Rodzaj paliwa")]
        public string Paliwo { get; set; }
        public string Kolor { get; set; }
        [DisplayName("Cena wypożyczenia (1 dzień)")]
        public int Cena { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Nazwa fotki")]
        public string ImageTitle { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string ImageName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Opis { get; set; }

        [NotMapped]
        [DisplayName("Wczytaj plik")]
        
        public IFormFile ImageFile { get; set; }
        
        // 

    }
}
