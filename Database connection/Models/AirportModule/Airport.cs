using Database_connection.Models.GateModule;
using Database_connection.Models.PassengerModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Models.AirportModule
{
    public class Airport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        public string Country { get; set; }

        [Required]
        [StringLength(64)]
        public string City { get; set; }

        [Required]
        [StringLength(3)]
        public string CodeIATA { get; set; }

        [Required]
        [StringLength(4)]
        public string CodeICAO { get; set; }

        [Required]
        public int IdGate { get; set; }

        [ForeignKey("IdGate")]
        public Gate Gate { get; set; }

        public Airport(int id, string name, string country, string city, string codeIATA, string codeICAO, int idGate, Gate gate)
        {
            Id = id;
            Name = name;
            Country = country;
            City = city;
            CodeIATA = codeIATA;
            CodeICAO = codeICAO;
            IdGate = idGate;
            Gate = gate;
        }
    }
}
