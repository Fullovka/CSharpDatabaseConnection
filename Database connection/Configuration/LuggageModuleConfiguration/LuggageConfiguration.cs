// Прописываем путь для подключения модели
using Database_connection.Models.LuggageModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.LuggageModuleConfiguration
{
    public class LuggageConfiguration : EntityTypeConfiguration<Luggage>
    {
        public LuggageConfiguration() 
        {
            this.ToTable("Luggage").HasKey(p => p.Id);

            this.HasRequired(x => x.Ticket)
                .WithMany()
                .HasForeignKey(p => p.IdTicket);
        }
    }
}
