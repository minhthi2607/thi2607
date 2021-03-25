using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary1.Model
{
    [Table("Topics")]
    class Topic
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Slug { get; set; }
        public int? Parentid { get; set; }
        public int? Orders { get; set; }
        public string Metakey { get; set; }
        public string Metadesc { get; set; }
        public int? Created_by { get; set; }
        public DateTime? Created_at { get; set; }
        public int? Updated_by { get; set; }
        public DateTime? Updated_at { get; set; }
        public int Status { get; set; }
    }
}
