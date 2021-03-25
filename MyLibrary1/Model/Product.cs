using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary1.Model
{
    [Table("Products")]
    class Product
    {
        [Key]
        public int Id { get; set; }
        public int Catid { get; set; }
        public string Name { get; set; }
        [Required]
        public string Slug { get; set; }
        public string Img { get; set; }
        public string Detail { get; set; }
        public int Number { get; set; }
        public float Price { get; set; }
        public float Pricesale { get; set; }
        public string Metakey { get; set; }
        public string Metadesc { get; set; }
        public int? Created_by { get; set; }
        public DateTime? Created_at { get; set; }
        public int? Updated_by { get; set; }
        public DateTime? Updated_at { get; set; }
        public int Status { get; set; }

    }
}
