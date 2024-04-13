using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.datalayer.EFModels
{
    public class Role
    {
        public byte Id { get; set; }
        
        [StringLength(30)]
        public string Name { get; set; } = string.Empty;
    }
}
