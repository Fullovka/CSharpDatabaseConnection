using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_connection.Models.GateModule
{
    public class Gate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Type { get; set; } = "Прилёт";

        [Required]
        [StringLength(64)]
        public string Location { get; set; }

    public Gate(int id, string type, string location)
        {
            Id = id;
            Type = type;
            Location = location;
        }
    }
}
