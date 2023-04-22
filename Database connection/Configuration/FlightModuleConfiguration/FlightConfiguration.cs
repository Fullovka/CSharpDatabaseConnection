// Прописываем путь для подключения модели
using Database_connection.Models.FlightModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.FlightModuleConfiguration
{
    public class FlightConfiguration : EntityTypeConfiguration<Flight>
    {
        public FlightConfiguration() 
        {
            this.ToTable("Flight").HasKey(p => p.Id);

            this.HasRequired(x => x.Plane)
                .WithMany()
                .HasForeignKey(p => p.IdPlane);
        }
    }
}
