using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary1.Model
{
    [Table("Posts")]
    class Post
    {
        [Key]
        public int Id { get; set; }
        public int Topid { get; set; }
        public string Title { get; set; }
        [Required]
        public string Slug { get; set; }
        public string Detail { get; set; }
        public string Img { get; set; }
        public string Type { get; set; }
        [Required]
        public string Metakey { get; set; }
        [Required]
        public string Metadesc { get; set; }
        public int? Created_by { get; set; }
        public DateTime? Created_at { get; set; }
        public int? Updated_by { get; set; }
        public DateTime? Updated_at { get; set; }
        public int Status { get; set; }
    }
}
