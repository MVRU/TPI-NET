using ProyectoNET.Properties;

public interface ISessionService
{
    void SaveSession(string userId, bool mantenerSesion);
    string LoadSession();
    void ClearSession();
}

public class SessionService : ISessionService
{
    public void SaveSession(string userId, bool mantenerSesion)
    {
        Settings.Default.UserId = userId;
        Settings.Default.MantenerSesion = mantenerSesion;
        Settings.Default.Save();
    }

    public string LoadSession()
    {
        if (Settings.Default.MantenerSesion)
        {
            return Settings.Default.UserId;
        }
        return string.Empty;
    }

    public void ClearSession()
    {
        Settings.Default.UserId = string.Empty;
        Settings.Default.MantenerSesion = false;
        Settings.Default.Save();
    }
}
