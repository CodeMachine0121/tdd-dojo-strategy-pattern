namespace Strategy_Pattern.Service;

public class KillerService
{
    public string Kill(string weapon)
    {
        if (weapon == "gun")
        {
            return "kill by gun";
        }

        return "kill by knife";
    }
}