using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPersonel__18_04.Models
{
    public class Personel
    {
        [Key]
        public int PersonelNo { get; set; }

        public string? Ad { get; set; }

        public string? Soyad { get; set; }

        public string? Adres { get; set; }

        public decimal Maas { get; set; }

        public string? Resim { get; set; }
    }
}