// Прописываем путь для подключения модели
using Database_connection.Models.AccountModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.AccountModuleConfiguration
{
    public class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration() 
        {
            this.ToTable("Account").HasKey(p => p.Id);

            this.HasRequired(x => x.Employee)
                .WithMany()
                .HasForeignKey(p => p.IdEmployee);
        }
    }
}
