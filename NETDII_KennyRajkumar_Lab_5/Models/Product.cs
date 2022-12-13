using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETDII_KennyRajkumar_Lab_5.Models
{
    public class Product
    {
        //Creates primary key Product ID
        [DisplayName("Product ID")]
        public int productID { get; set; }

        //Creates Product Image / Image Name
        [DisplayName("Image Name")]
        public string productImage { get; set; }

        //Creates Product name string
        [DisplayName("Product Name")]
        public string productName { get; set; }

        //Creates Product Description string
        [DisplayName("Product Description")]
        public string productDesc { get; set; }

        //Creates Product Price double
        [DisplayName("Product Price")]
        public double productPrice { get; set; }

        //Creates a non-mapped IFormFile / ImageFile so it's not stored in the database
        [NotMapped]
        [DisplayName("Product Picture")]
        public IFormFile ImageFile { get; set; }
    }
}
