global using Microsoft.EntityFrameworkCore;

namespace UdemyAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        //Our set of characters that we can get and modify and resave to the db
        //This is how entity framework knows to make a representation of our model 'Character' in the DB
        //To add migration go to tools -> nuget pack manager -> console then type Add-Migration {migration name}
        //To add to database type Update-Database
        public DbSet<Character> Characters => Set<Character>();
        public DbSet<User> Users => Set<User>();


    }
}
