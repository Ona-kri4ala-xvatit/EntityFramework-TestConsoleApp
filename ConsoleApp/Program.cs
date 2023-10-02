using ConsoleApp.Repositories;

var playerRepo = new PlayerEFRepository();

#region InsertIntoPlayersTable
//var firstGoalKeeper = new Player("David DeGea", 30);
//var secondGoalKeeper = new Player("Andre Onana", 26);

//db.Players.AddRange(firstGoalKeeper, secondGoalKeeper);
//db.SaveChanges();
#endregion

#region GetAllPlayers
//var players = playerRepo.GetAllPlayers().ToList();

//foreach (var player in players)
//{
//    Console.WriteLine(player);
//}
#endregion

#region GetById
//var player = playerRepo.GetPlayerById(1);
//Console.WriteLine(player);
#endregion

#region UpdatePlayer
//playerRepo.UpdatePlayer(3, "Cristiano Ronaldo", 38);
//playerRepo.GetAllPlayers().ToList().ForEach(Console.WriteLine);
#endregion

#region DeleteById
//playerRepo.DeletePlayer(4);
//playerRepo.GetAllPlayers().ToList().ForEach(Console.WriteLine);
#endregion

