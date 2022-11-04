// To registeration into a play and validation of persons data etc, project as a OOP example.

using GameProject;

internal class NewUserValidationManager : IUserValidationService
{
    public bool Validate(Gamer gamer)
    {
        if (gamer.Name == "Fahri")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}