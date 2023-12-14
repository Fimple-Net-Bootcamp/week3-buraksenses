using Newtonsoft.Json;

namespace VirtualPetCare.API.Application.DTOs.Nutrition;

public class RetrieveNutritionRequestDto
{
    public string Name { get; set; }

    public float Calories { get; set; }
    
    public string ForWhichPetJson
    {
        get => JsonConvert.SerializeObject(ForWhichPet);
        set => ForWhichPet = JsonConvert.DeserializeObject<string[]>(value);
    }
    public string[]? ForWhichPet { get; set; }
    
    public int Quantity { get; set; }
}