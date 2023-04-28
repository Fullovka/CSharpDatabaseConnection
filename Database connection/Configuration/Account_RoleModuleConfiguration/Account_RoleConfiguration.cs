// Прописываем путь для подключения модели
using Database_connection.Models.Account_RoleModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.Account_RoleModuleConfiguration
{
    public class Account_RoleConfiguration : EntityTypeConfiguration<Account_Role>
    {
        public Account_RoleConfiguration() 
        {
            this.ToTable("Account_Role").HasKey(p => p.Id);

            this.HasRequired(x => x.Account)
                .WithMany()
                .HasForeignKey(p => p.IdAccount);

            this.HasRequired(x => x.Role)
                .WithMany()
                .HasForeignKey(p => p.IdRole);
        }
    }
}
