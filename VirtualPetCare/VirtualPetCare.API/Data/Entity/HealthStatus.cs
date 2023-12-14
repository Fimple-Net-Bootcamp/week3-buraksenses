namespace VirtualPetCare.API.Data.Entity;
using Core;

public class HealthStatus : Entity
{
    public DateTime CheckupDate { get; set; }

    public string Notes { get; set; }

    public string VaccinationStatus { get; set; }

    public float Weight => Pet.Weight;

    public Guid PetId { get; set; }
    
    //Navigation Properties
    public Pet Pet { get; set; }
}