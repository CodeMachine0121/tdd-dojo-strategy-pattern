using Strategy_Pattern.Service.Weapons.Interfaces;

namespace Strategy_Pattern.Service.Weapons;

public class Gun : IWeapon
{
    public string Kill()
    {
        return "kill by gun";
    }
}