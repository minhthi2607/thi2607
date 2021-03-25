using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary1.Model
{
    [Table("Orders")]
    class Order
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public int Userid { get; set; }
        public string Deliveryaddress { get; set; }
        public string Deliveryname { get; set; }
        public string Deliveryphone { get; set; }
        public string Deliveryemail { get; set; }
        public int? Updated_by { get; set; }
        public DateTime? Updated_at { get; set; }
        public int Status { get; set; }
    }
}
