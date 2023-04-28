using Database_connection.Models.AirportModule;
using Database_connection.Models.FlightModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Models.Flight_AirportModule
{
    public class Flight_Airport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int IdFlight { get; set; }

        [ForeignKey("IdFlight")]
        public Flight Flight { get; set; }

        [Required]
        public int IdAirport { get; set; }

        [ForeignKey("IdAirport")]
        public Airport Airport { get; set; }
        
        public Flight_Airport(int id, int idFlight, Flight flight, int idAirport, Airport airport)
        {
            Id = id;
            IdFlight = idFlight;
            Flight = flight;
            IdAirport = idAirport;
            Airport = airport;
        }
    }
}
