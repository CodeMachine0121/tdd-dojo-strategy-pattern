using Strategy_Pattern.Service.Weapons.Interfaces;

namespace Strategy_Pattern.Service.Weapons;

internal class Poison : IWeapon
{
    public string Kill()
    {
        return "kill by poison";
    }
}