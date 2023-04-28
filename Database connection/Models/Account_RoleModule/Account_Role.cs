using Database_connection.Models.AccountModule;
using Database_connection.Models.RoleModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Models.Account_RoleModule
{
    public class Account_Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int IdAccount { get; set; }

        [ForeignKey("IdAccount")]
        public Account Account { get; set; }

        [Required]
        public int IdRole { get; set; }

        [ForeignKey("IdRole")]
        public Role Role { get; set; }

        public Account_Role(int id, int idAccount, Account account, int idRole, Role role)
        {
            Id = id;
            IdAccount = idAccount;
            Account = account;
            IdRole = idRole;
            Role = role;
        }
    }
}
