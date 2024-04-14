using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.datalayer.EFModels
{
    public class UserRoleMapping
    {
        public int Id { get; set; } 
        public int UserId { get; set; }
        
        [ForeignKey("UserId")]
        public UserInfo UserInfo { get; set; }

        public byte RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; } = null!;


    }
}
