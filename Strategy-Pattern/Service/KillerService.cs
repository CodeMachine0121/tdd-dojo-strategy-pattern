namespace Strategy_Pattern.Service;

public class Knife
{
    public static string KillByKnife()
    {
        return "kill by knife";
    }
}

public class Gun
{
    public static string KillByGun()
    {
        return "kill by gun";
    }
}

public class KillerService
{
    public string Kill(string weapon)
    {
        if (weapon == "gun")
        {
            return Gun.KillByGun();
        }

        return Knife.KillByKnife();
    }
}