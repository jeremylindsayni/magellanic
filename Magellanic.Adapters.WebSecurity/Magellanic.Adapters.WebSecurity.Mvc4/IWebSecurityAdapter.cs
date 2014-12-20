namespace Magellanic.Adapters.WebSecurity.Mvc4
{
    public interface IWebSecurityAdapter
    {
        /// <summary>
        /// Creates the user and account.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        void CreateUserAndAccount(string userName, string password);

        /// <summary>
        /// Logs the user on.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        bool LogUserOn(string userName, string password);

        /// <summary>
        /// Logs the user on.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <param name="rememberMe">if set to <c>true</c> [remember me].</param>
        /// <returns></returns>
        bool LogUserOn(string userName, string password, bool rememberMe);

        /// <summary>
        /// Logs the current user out.
        /// </summary>
        void LogCurrentUserOut();
    }
}
