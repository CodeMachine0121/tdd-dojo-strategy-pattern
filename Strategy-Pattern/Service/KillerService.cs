using Strategy_Pattern.Service.Weapons;
using Strategy_Pattern.Service.Weapons.Interfaces;

namespace Strategy_Pattern.Service;

public class KillerService
{
    private readonly Dictionary<string, IWeapon> _weapons = new()
    {
        {"gun", new Gun()},
        {"knife", new Knife()},
        {"poison", new Poison()}
    };

    public string Kill(string weapon)
    {
        return _weapons[weapon].Kill();
    }
}