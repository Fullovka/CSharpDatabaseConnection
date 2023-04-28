// Прописываем путь для подключения модели
using Database_connection.Models.PostModule;

// Подключаем необходимую библиотеку
using System.Data.Entity.ModelConfiguration;

namespace Database_connection.Configuration.PostModuleConfiguration
{
    internal class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration() 
        {
            this.ToTable("Post").HasKey(p => p.Id);
        }
    }
}
