using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary1.Model
{
    [Table("Links")]
    class Link
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Slug { get; set; }
        public string Type { get; set; }
        public int Tableid { get; set; }

    }
}
