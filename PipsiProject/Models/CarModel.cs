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
        [Required(ErrorMessage = "To pole jest wymagane")]
        public string Marka { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane")]
        public string Model { get; set; }

        public string Klasa { get; set; }
        [DisplayName("Pojemność skokowa (cm3)")]
        //[RegularExpression(@"^[0-9]""'\s-]*$")]     // ogranicza wprowadzanie znaków - sprawdz pozniej
        //   [MaxLength(4)]

        [Range(1000, 9999, ErrorMessage ="Wprowadź pojemność silnika w cm3")]
        public int PojSilnika { get; set; }

     //   [MaxLength(6)]
        [DisplayName("Przebieg (km)")]
        [Range(1000, 999999, ErrorMessage ="Wprowadź prawidłowy przebieg w km")]
        public double Przebieg { get; set; }

        [DisplayName("Rok produkcji")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM}", ApplyFormatInEditMode = true)]
        
        public DateTime RokProd { get; set; }

        [DisplayName("Rodzaj paliwa")]
        public string Paliwo { get; set; }
        public string Kolor { get; set; }

        [DisplayName("Cena wypożyczenia (1 dzień)")]
     //   [MaxLength(4)]
        public int Cena { get; set; }
      //  [MaxLength(600)]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Opis { get; set; }

        [DisplayName("Zdjęcie")]
        public ImageModel CarImage { get; set; }

        // 

    }
}
