using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary1.Model
{
    [Table("Contacts")]
    class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Replaydetail { get; set; }
        public int? Updated_by { get; set; }
        public DateTime? Updated_at { get; set; }
        public int Status { get; set; }
    }
}
