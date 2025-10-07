using gettingstarted.Mobs;

public enum Item { Wheat, Seeds }

public interface IBreedable
{
    Item GetBreedableItem();
}