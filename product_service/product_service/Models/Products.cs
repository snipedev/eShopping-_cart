using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace product_service.Models
{
    public class Products
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }
        public string CategoryId { get; set; }
    }
}
