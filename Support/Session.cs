using VRMS.Models.Accounts;

namespace VRMS.Support
{
    /// <summary>
    /// Holds the currently logged-in user for the application session.
    /// </summary>
    public static class Session
    {
        public static User? CurrentUser { get; set; }

        public static bool IsLoggedIn => CurrentUser != null;

        public static void Clear()
        {
            CurrentUser = null;
        }
    }
}
