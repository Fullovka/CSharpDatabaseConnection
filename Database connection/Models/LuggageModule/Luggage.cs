using Database_connection.Models.TicketModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Models.LuggageModule
{
    public class Luggage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public float Weight { get; set; }

        [Required]
        [StringLength(64)]
        public string Size { get; set; }

        [Required]
        [StringLength(128)]
        public string Description { get; set; }

        [Required]
        public int IdTicket { get; set; }

        [ForeignKey("IdTicket")]
        public Ticket Ticket { get; set; }

        public Luggage(int id, float weight, string size, string description, int idTicket, Ticket ticket)
        {
            Id = id;
            Weight = weight;
            Size = size;
            Description = description;
            IdTicket = idTicket;
            Ticket = ticket;
        }
    }
}
