// Прописываем путь для подключения модели
using Database_connection.Models.PlaneModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.PlaneModuleConfiguration
{
    public class PlaneConfiguration : EntityTypeConfiguration<Plane>
    {
        public PlaneConfiguration() 
        {
            this.ToTable("Plane").HasKey(p => p.Id);

            this.HasRequired(x => x.Airline)
                .WithMany()
                .HasForeignKey(p => p.IdAirline);
        }
    }
}
