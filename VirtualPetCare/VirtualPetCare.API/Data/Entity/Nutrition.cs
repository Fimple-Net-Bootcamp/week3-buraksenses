namespace VirtualPetCare.API.Data.Entity;
using Core;

public class Nutrition : Entity
{
    public string Name { get; set; }

    public float Calories { get; set; }

    public string[] ForWhichPet { get; set; }

    public int Quantity { get; set; }
}