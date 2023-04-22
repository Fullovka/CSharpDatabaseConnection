// Прописываем путь для подключения модели
using Database_connection.Models.AirlineModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.AirlineModuleConfiguration
{
    internal class AirlineConfiguration : EntityTypeConfiguration<Airline>
    {
        public AirlineConfiguration() 
        {
            this.ToTable("Airline").HasKey(p => p.Id);
        }
    }
}
