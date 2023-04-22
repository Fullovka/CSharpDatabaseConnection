// Прописываем путь для подключения модели
using Database_connection.Models.GateModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.GateModuleConfiguration
{
    internal class GateConfiguration : EntityTypeConfiguration<Gate>
    {
        public GateConfiguration() 
        {
            this.ToTable("Gate").HasKey(p => p.Id);
        }
    }
}
