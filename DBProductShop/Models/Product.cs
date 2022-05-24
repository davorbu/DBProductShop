﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBProductShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }


        [Required(ErrorMessage = "Please enter product name")]
        public string? Name { get; set; }


        [Required(ErrorMessage = "Please enter product price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "Please select category")]
        public int CategoryID { get; set; } //foreign key


        public Category Category { get; set; }

        public decimal DiscountPercent => .20M;
        public decimal DiscountAmount => Price * DiscountPercent;
        public decimal DiscountPrice => Price - DiscountAmount;


        [Required(ErrorMessage = "Please enter product code")]
        public string? Code { get; set; }

        public string Slug => Name == null ? "" : Name.Replace(' ', '-');

        

    }
}
