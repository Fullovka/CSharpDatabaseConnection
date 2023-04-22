// Прописываем путь для подключения модели
using Database_connection.Models.PassengerModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.PassengerModuleConfiguration
{
    internal class PassengerConfiguration : EntityTypeConfiguration<Passenger>
    {
        public PassengerConfiguration() 
        {
            this.ToTable("Passenger").HasKey(p => p.Id);
        }
    }
}
