using Database_connection.Models.PlaneModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Models.FlightModule
{
    public class Flight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [Required]
        [StringLength(64)]
        public string Status { get; set; }

        [Required]
        [StringLength(64)]
        public string DepartureAirport { get; set; } = "Московский аэропорт Шереметьево";

        [Required]
        public int IdPlane { get; set; }

        [ForeignKey("IdPlane")]
        public Plane Plane { get; set; }

        public Flight(int id, DateTime departureTime, DateTime arrivalTime, string status, string departureAirport, int idPlane)
        {
            Id = id;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            Status = status;
            DepartureAirport = departureAirport;
            IdPlane = idPlane;
        }
    }
}
