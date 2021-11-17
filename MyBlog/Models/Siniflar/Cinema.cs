using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models.Siniflar
{
    public class Cinema
    {
        [Key]
        public int ID { get; set; }
        public string FilmAdi { get; set; }
        public string Yonetmen { get; set; }
        public string İmgCinema { get; set; }
        public string İmgCinema2 { get; set; }
        public string İmgCinema3 { get; set; }
        public string FilmiOneren { get; set; }
        public DateTime FilmCikisTarihi { get; set; }
        public string FilmHakkinda { get; set; }
        public string FilmKategori { get; set; }
        public string DiziorFilm { get; set; }
    }
}