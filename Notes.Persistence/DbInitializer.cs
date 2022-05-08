namespace Notes.Persistence
{
    public class DbInitializer
    {
        // init for fist app running
        public static void Initialize(NotesDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
