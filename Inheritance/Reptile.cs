namespace Inheritance;

public class Reptile:Animal
{
    public Reptile()
    {
        IsAlive = true;
        BreathOxygen = true;
        CanMove = true;
        Age = 5;
        Name = "Reptile";
        IsColdBlooded = true;
    }


    public bool IsSkaly { get; set; }
    public bool LayEggs { get; set; }
    public bool HaveLungs { get; set; }
    public string Habitat { get; set; }

}