using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace SoapLush.Models
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string Ingredients { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public double Price { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; } //foreign key
        public Category Category { get; set; } //Reference Navigation


        [ForeignKey("SubCategory")]
        [AllowNull]
        public int? SubCategoryId { get; set; } = null;//foreign key
        public SubCategory? SubCategory { get; set; } //Reference Navigation

        

    }
}
