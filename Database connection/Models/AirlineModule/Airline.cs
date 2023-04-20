using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Models.AirlineModule
{
    public class Airline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        public string CountryOfRegistration { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal AnnualTurnover { get; set; }

        public Airline(int id, string name, string countryOfRegistration, decimal annualTurnover)
        {
            Id = id;
            Name = name;
            CountryOfRegistration = countryOfRegistration;
            AnnualTurnover = annualTurnover;
        }
    }
}
