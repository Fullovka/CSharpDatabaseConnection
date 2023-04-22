// Подключение конфигураций для моделей
using Database_connection.Configuration.AirlineModuleConfiguration;
using Database_connection.Configuration.AirportModuleConfiguration;
using Database_connection.Configuration.FlightModuleConfiguration;
using Database_connection.Configuration.Flight_AirportModuleConfiguration;
using Database_connection.Configuration.GateModuleConfiguration;
using Database_connection.Configuration.LuggageModuleConfiguration;
using Database_connection.Configuration.PassengerModuleConfiguration;
using Database_connection.Configuration.PlaneModuleConfiguration;
using Database_connection.Configuration.TicketModuleConfiguration;

// Подключение моделей
using Database_connection.Models.AirlineModule;
using Database_connection.Models.AirportModule;
using Database_connection.Models.Flight_AirportModule;
using Database_connection.Models.FlightModule;
using Database_connection.Models.GateModule;
using Database_connection.Models.LuggageModule;
using Database_connection.Models.PassengerModule;
using Database_connection.Models.PlaneModule;
using Database_connection.Models.TicketModule;

// Подключение библиотеку Entity
using System.Data.Entity;

namespace Database_connection.Context
{
    public class MainDBContext : DbContext
    {
        public DbSet<Airline> Airlines { get; set; }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Flight_Airport> Flight_Airports { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public DbSet<Gate> Gates { get; set; }

        public DbSet<Luggage> Luggages { get; set; }

        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Plane> Planes { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        static MainDBContext()
        {
            Database.SetInitializer<MainDBContext>(null);
        }

        public MainDBContext() : base("UserDB") 
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AirlineConfiguration());
            modelBuilder.Configurations.Add(new AirportConfiguration());
            modelBuilder.Configurations.Add(new Flight_AirportConfiguration());
            modelBuilder.Configurations.Add(new FlightConfiguration());
            modelBuilder.Configurations.Add(new GateConfiguration());
            modelBuilder.Configurations.Add(new LuggageConfiguration());
            modelBuilder.Configurations.Add(new PassengerConfiguration());
            modelBuilder.Configurations.Add(new PlaneConfiguration());
            modelBuilder.Configurations.Add(new TicketConfiguration());
        }
    }
}
