using Database_connection.Models.AirlineModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Models.PlaneModule
{
    public class Plane
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        public string Model { get; set; }

        [Required]
        public DateTime YearOfRelease { get; set; }

        [Required]
        public int NumberOfSeats { get; set; }

        [Required]
        public int IdAirline { get; set; }

        [ForeignKey("IdAirline")]
        public Airline Airline { get; set; }

        public Plane(int id, string name, string model, DateTime yearOfRelease, int numberOfSeats, int idAirline)
        {
            Id = id;
            Name = name;
            Model = model;
            YearOfRelease = yearOfRelease;
            NumberOfSeats = numberOfSeats;
            IdAirline = idAirline;
        }
    }
}
