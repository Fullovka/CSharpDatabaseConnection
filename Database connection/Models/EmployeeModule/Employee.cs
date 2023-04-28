using Database_connection.Models.AirlineModule;
using Database_connection.Models.PostModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Models.EmployeeModule
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Surname { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        public string Patronymic { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Salary { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [Required]
        public int IdAirline { get; set; }

        [ForeignKey("IdAirline")]
        public Airline Airline { get; set; }

        [Required]
        public int IdPost { get; set; }

        [ForeignKey("IdPost")]
        public Post Post { get; set; }

        public Employee(int id, string surname, string name, string patronymic, decimal salary, DateTime hireDate, int idAirline, Airline airline, int idPost, Post post)
        {
            Id = id;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Salary = salary;
            HireDate = hireDate;
            IdAirline = idAirline;
            Airline = airline;
            IdPost = idPost;
            Post = post;
        }
    }
}
