namespace gettingstarted.Mobs;

public class Chicken : Mob, IBreedable
{
    public Item GetBreedableItem()
    {
        return Item.Seeds;
    }
}
