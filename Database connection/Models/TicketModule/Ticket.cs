using Database_connection.Models.FlightModule;
using Database_connection.Models.PassengerModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Models.TicketModule
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime DateOfPurchase { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Cost { get; set; }

        [Required]
        public int IdFlight { get; set; }

        [ForeignKey("IdFlight")]
        public Flight Flight { get; set; }

        [Required]
        public int IdPassenger { get; set; }

        [ForeignKey("IdPassenger")]
        public Passenger Passenger { get; set; }

        public Ticket(int id, DateTime dateOfPurchase, decimal cost, int idFlight, int idPassenger)
        {
            Id = id;
            DateOfPurchase = dateOfPurchase;
            Cost = cost;
            IdFlight = idFlight;
            IdPassenger = idPassenger;
        }
    }
}
