using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notes.Domain;

namespace Notes.Persistence.EntityTypeConfigurations
{
    /// <summary>
    /// выносим настройку модели в отдельный класс(ы) разгружаем метод OnModelCreating.
    /// </summary>
    public class NotesConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            // all configuration read in documentation :0)
            builder.HasKey(note => note.Id);
            builder.HasIndex(note => note.Id).IsUnique();
            builder.Property(note => note.Title).IsRequired().HasMaxLength(256);  
        }
    }
}
