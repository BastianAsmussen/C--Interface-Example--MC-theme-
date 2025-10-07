using gettingstarted.Mobs;
using gettingstarted;

List<Mob> getNearbyMobs()
{
    List<Mob> mobs = new();
    mobs.Add(new Villager());
    mobs.Add(new Cow());
    mobs.Add(new Sheep());

    return mobs;
}

List<Mob> nearbyMobs = getNearbyMobs();

Player player = new Player();
player.Update();
