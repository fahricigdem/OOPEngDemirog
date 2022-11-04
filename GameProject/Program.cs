// To registeration into a play and validation of persons data etc, project as a OOP example.

using GameProject;

GamerManager gamerManager = new GamerManager(new UserValidationManager());
Gamer gamer = new() { Id = 1, Name = "Fahri" };
gamerManager.Add(gamer);


GamerManager gamerManager2 = new GamerManager(new NewUserValidationManager()); // a new manager is used
Gamer gamer2 = new() { Name = "Fahri" };
gamerManager2.Add(gamer2);
