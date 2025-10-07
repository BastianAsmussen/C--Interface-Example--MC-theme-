namespace gettingstarted.Mobs;

public enum Aggression { Passive, SemiPassive, Aggressive }

public abstract class Mob : Entity
{
    public Aggression Aggression { get; set; }

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
        Player player = Player.Current;
        List<Mob> nearbyMobs = getNearbyMobs();
        
        foreach (Mob mob in nearbyMobs)
        {
        }
    }
}
