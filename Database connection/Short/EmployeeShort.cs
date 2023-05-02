using Database_connection.Models.AirlineModule;
using Database_connection.Models.PostModule;
using System;

namespace Database_connection.Short
{
    internal class EmployeeShort
    {
        public int Id { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Patronymic { get; set; }

        public decimal Salary { get; set; }

        public DateTime HireDate { get; set; }

        public int IdAirline { get; set; }

        public Airline Airline { get; set; }

        public int IdPost { get; set; }

        public Post Post { get; set; }
    }
}
