using ConsoleApp.Models;

namespace ConsoleApp.Repositories
{
    public class PlayerEFRepository
    {
        ApplicationDbContext dbContext;
        public PlayerEFRepository()
        {
            dbContext = new ApplicationDbContext();
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            return dbContext.Players.ToList();
        }

        public Player GetPlayerById(int id)
        {
            return dbContext.Players.FirstOrDefault(x => x.Id == id)!;
        }

        public void UpdatePlayer(int id, string fullname, int age)
        {
            var player = GetPlayerById(id);
            player.FullName = fullname;
            player.Age = age;
            dbContext.SaveChanges();
        }

        public void DeletePlayer(int id)
        {
            var player = GetPlayerById(id);
            dbContext.Remove(player);
            dbContext.SaveChanges();
        }
    }
}
