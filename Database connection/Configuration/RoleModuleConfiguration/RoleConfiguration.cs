// Прописываем путь для подключения модели
using Database_connection.Models.RoleModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.RoleModuleConfiguration
{
    internal class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration() 
        {
            this.ToTable("Role").HasKey(p => p.Id);
        }
    }
}
