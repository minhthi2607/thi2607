using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary1.Model
{
    [Table("Orderdetails")]
    class Orderdetail
    {
        [Key]
        public int Id { get; set; }
        public int Orderid { get; set; }
        public int Productid { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public float Amount { get; set; }

    }
}
