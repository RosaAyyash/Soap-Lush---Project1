using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace SoapLush.Models
{
    public class SubCategory
    {
        public int id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CategoryId { get; set; } //foreign key
        public Category? Category { get; set; }
        public ICollection<Product> Products { get; set;} //collection navigation

        
    }
}
