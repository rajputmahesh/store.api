using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.datalayer.EFModels
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string Image { get; set; } = string.Empty;
        [StringLength(500)]
        
        public string Category { get; set; } = string.Empty;
        
        public double Price { get; set; }
        
        public byte Rating { get; set; }
    }
}
