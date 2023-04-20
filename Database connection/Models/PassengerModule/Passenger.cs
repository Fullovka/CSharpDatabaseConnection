using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Models.PassengerModule
{
    public class Passenger
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
        [StringLength(4)]
        public string PassportSeries { get; set; }

        [Required]
        [StringLength(6)]
        public string PassportNumber { get; set; }

        [Required]
        [StringLength(128)]
        public string Issued { get; set; }

        [Required]
        [StringLength(64)]
        public string Citizenship { get; set; }

        public Passenger (int id, string surname, string name, string patronymic, string passportSeries, string passportNumber, string issued, string citizenship)
        {
            Id = id;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
            Issued = issued;
            Citizenship = citizenship;
        }
    }
}
