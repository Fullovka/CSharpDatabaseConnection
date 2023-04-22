// Прописываем путь для подключения модели
using Database_connection.Models.TicketModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.TicketModuleConfiguration
{
    public class TicketConfiguration : EntityTypeConfiguration<Ticket>
    {
        public TicketConfiguration() 
        {
            this.ToTable("Ticket").HasKey(p => p.Id);

            this.HasRequired(x => x.Flight)
                .WithMany()
                .HasForeignKey(p => p.IdFlight);

            this.HasRequired(x => x.Passenger)
                .WithMany()
                .HasForeignKey(p => p.IdPassenger);
        }
    }
}
