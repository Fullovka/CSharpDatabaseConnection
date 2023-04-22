// Прописываем путь для подключения модели
using Database_connection.Models.AirportModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.AirportModuleConfiguration
{
    public class AirportConfiguration : EntityTypeConfiguration<Airport>
    {
        public AirportConfiguration() 
        { 
            this.ToTable("Airport").HasKey(p => p.Id);

            this.HasRequired(x => x.Gate)
                .WithMany()
                .HasForeignKey(p => p.IdGate);
        }
    }
}
