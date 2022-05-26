using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Data.DataModels
{
    // Data annotaions
    [Table("practice1_user", Schema = "practice_1")]
    public class Practice1_User
    {
        [Key, StringLength(50), Column("userid", TypeName = "varchar(50)")]
        public string UserId { get; set; }
        [Required, StringLength(100), Column("username", TypeName = "varchar(100)")]
        public string UserName { get; set; }
        [Required, StringLength(320), Column("useremail", TypeName = "varchar(320)")]
        public string UserEmail { get; set; }
        [Required, StringLength(130), Column ("password", TypeName = "varchar(130)")]
        public string Password { get; set; }
        [Required, Column ("ismembershipwithdrawn")]
        public Boolean IsMembershipWithdrawn { get; set; }
        [Required, Column("joinedutcdate")]
        public DateTime JoinedUtcDate { get; set; }
        // FK지정
        // [ForeignKey("UserId")]
        // public virtual ICollection<Practice1_UserRolesByUser> UserRolesByUsers { get; set; }
    }
}
