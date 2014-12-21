// ***********************************************************************
// Assembly         : Magellanic.Adapters.WebSecurity.Mvc5
// Author           : Jeremy Lindsay
// Created          : 12-20-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 12-21-2014
// ***********************************************************************
/// <summary>
/// The WebSecurity.Mvc5 namespace.
/// </summary>
namespace Magellanic.Adapters.WebSecurity.Mvc5
{
    using Magellanic.Interfaces.WebSecurity;
    using WebMatrix.WebData;

    /// <summary>
    /// The WebSecurityAdapter class.
    /// </summary>
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
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
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
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool LogUserOn(string userName, string password, bool rememberMe)
        {
            return WebSecurity.Login(userName, password, persistCookie: rememberMe);
        }
    }
}
