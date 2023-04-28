using Database_connection.Models.EmployeeModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Models.AccountModule
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Login { get; set; }

        [Required]
        [StringLength(64)]
        public string Password { get; set; }

        [Required]
        [StringLength(64)]
        public string Email { get; set; }

        [Required]
        public int IdEmployee { get; set; }

        [ForeignKey("IdEmployee")]
        public Employee Employee { get; set; }

        public Account(int id, string login, string password, string email, int idEmployee, Employee employee)
        {
            Id = id;
            Login = login;
            Password = password;
            Email = email;
            IdEmployee = idEmployee;
            Employee = employee;
        }
    }
}
