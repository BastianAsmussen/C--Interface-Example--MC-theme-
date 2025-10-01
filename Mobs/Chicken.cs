namespace gettingstarted.Mobs;

public class Chicken : Mob, IBreedable
{
    public string GetBreedableItem()
    {
        return "Seeds";
    }
}