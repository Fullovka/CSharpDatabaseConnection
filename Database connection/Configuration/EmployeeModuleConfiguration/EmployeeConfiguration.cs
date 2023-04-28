// Прописываем путь для подключения модели
using Database_connection.Models.EmployeeModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.EmployeeModuleConfiguration
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration() 
        {
            this.ToTable("Employee").HasKey(p => p.Id);

            this.HasRequired(x => x.Airline)
                .WithMany()
                .HasForeignKey(p => p.IdAirline);

            this.HasRequired(x => x.Post)
                .WithMany()
                .HasForeignKey(p => p.IdPost);
        }
    }
}
