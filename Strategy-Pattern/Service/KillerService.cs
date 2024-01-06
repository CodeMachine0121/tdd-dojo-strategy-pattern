namespace Strategy_Pattern.Service;

public class KillerService
{
    public string Kill(string weapon)
    {
        if (weapon == "gun")
        {
            return KillByGun();
        }

        return KillByKnife();
    }

    private static string KillByKnife()
    {
        return "kill by knife";
    }

    private static string KillByGun()
    {
        return "kill by gun";
    }
}