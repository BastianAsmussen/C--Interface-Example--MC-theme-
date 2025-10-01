namespace gettingstarted.Mobs;

public class Sheep : Mob, IBreedable
{
    public string GetBreedableItem()
    {
        return "Wheat";
    }
}