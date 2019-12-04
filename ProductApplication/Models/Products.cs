using System;
using System.ComponentModel.DataAnnotations;

namespace ProductApplication.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ReleasedDate{ get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}