namespace VirtualPetCare.API.Data.Entity;

using Core;

public class User : Entity
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }
}