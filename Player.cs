using gettingstarted.Mobs;

namespace gettingstarted;

public class Player : Entity
{
    public static Player Current = new Player();
    public Item ActiveItem { get; set; } = Item.Wheat;
    
    List<Mob> getNearbyMobs()
    {
        List<Mob> mobs = new();
        mobs.Add(new Villager());
        mobs.Add(new Cow());
        mobs.Add(new Sheep());

        return mobs;
    }

    public void Update()
    {
        List<Mob> nearbyMobs = getNearbyMobs();

        foreach (Mob mob in nearbyMobs)
        {
            // Check if mobs should go aggro
            if (mob.Target == null && mob.Aggression == Aggression.Aggressive)
            {
                mob.Target = this;
                
                continue;
            }
            
            // Check if mobs are attracted to players item in hand
            // TODO Rewrite as IBreedable instead of concrete classes (Sheep and Cow)
            if (mob is Sheep || mob is Cow)
            {
                if (ActiveItem != Item.Wheat) continue;
                mob.Target = this;

                continue;
            }

            if (mob is Chicken)
            {
                if (ActiveItem != Item.Seeds) continue;

                mob.Target = this;
            }
        }
    }
}