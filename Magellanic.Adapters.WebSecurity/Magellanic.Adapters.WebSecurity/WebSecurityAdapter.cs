namespace Magellanic.Adapters.WebSecurity
{
    using WebMatrix.WebData;

    public class WebSecurityAdapter : IWebSecurityAdapter
    {
        /// <summary>
        /// Logs the current user out.
        /// </summary>
        public void LogCurrentUserOut()
        {
            WebSecurity.Logout();
        }

        /// <summary>
        /// Creates the user and account.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        public void CreateUserAndAccount(string userName, string password)
        {
            WebSecurity.CreateUserAndAccount(userName, password);
        }

        /// <summary>
        /// Logs the user on.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool LogUserOn(string userName, string password)
        {
            return WebSecurity.Login(userName, password);
        }

        /// <summary>
        /// Logs the user on.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <param name="rememberMe">if set to <c>true</c> [remember me].</param>
        /// <returns></returns>
        public bool LogUserOn(string userName, string password, bool rememberMe)
        {
            return WebSecurity.Login(userName, password, persistCookie: rememberMe);
        }
    }
}
