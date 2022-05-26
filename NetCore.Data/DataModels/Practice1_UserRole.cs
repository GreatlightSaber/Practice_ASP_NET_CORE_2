using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Data.DataModels
{
    public class Practice1_UserRole
    {
        [Key, StringLength(50), Column(TypeName = "varchar(50)")]
        public string RoleId { get; set; }
        [Required, StringLength(100), Column(TypeName = "varchar(100)")]
        public string RoleName { get; set; }
        [Required]
        public byte RolePriority { get; set; }
        [Required]
        public DateTime ModifiedUtcDate { get; set; }

        //[ForeignKey("RoleId")]
        //public virtual ICollection<Practice1_UserRolesByUser> userRolesByUsers { get; set; }

    }
}
