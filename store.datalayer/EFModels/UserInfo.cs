using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.datalayer.EFModels
{
    [Table("UserInfo")]
    public class UserInfo
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string FirstName { get; set; } = string.Empty;
        
        [StringLength(30)]
        public string LastName { get; set; } = string.Empty;

        [StringLength(60)]
        public string Email { get; set; } = string.Empty;

    }
}
