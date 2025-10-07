namespace gettingstarted.Mobs;

public class Sheep : Mob, IBreedable
{
    public Item GetBreedableItem()
    {
        return Item.Wheat;
    }
}