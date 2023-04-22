// Прописываем путь для подключения модели
using Database_connection.Models.Flight_AirportModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.Flight_AirportModuleConfiguration
{
    public class Flight_AirportConfiguration : EntityTypeConfiguration<Flight_Airport>
    {
        public Flight_AirportConfiguration() 
        {
            this.ToTable("Flight_Airport").HasKey(p => p.Id);

            this.HasRequired(x => x.Flight)
                .WithMany()
                .HasForeignKey(p => p.IdFlight);

            this.HasRequired(x => x.Airport)
                .WithMany()
                .HasForeignKey(p => p.IdAirport);
        }
    }
}
