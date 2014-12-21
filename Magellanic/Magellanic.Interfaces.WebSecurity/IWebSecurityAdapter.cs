// ***********************************************************************
// Assembly         : Magellanic.Interfaces.WebSecurity
// Author           : Jeremy Lindsay
// Created          : 12-21-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 12-21-2014
// ***********************************************************************
// <summary>This project is a simple interface for handling basic web security operations, e.g. registration, logging a user on, logging a user out.</summary>
// ***********************************************************************
/// <summary>
/// The WebSecurity namespace.
/// </summary>
namespace Magellanic.Interfaces.WebSecurity
{
    /// <summary>
    /// The IWebSecurityAdapter interface definition.
    /// </summary>
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
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool LogUserOn(string userName, string password);

        /// <summary>
        /// Logs the user on.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="password">The password.</param>
        /// <param name="rememberMe">if set to <c>true</c> [remember me].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        bool LogUserOn(string userName, string password, bool rememberMe);

        /// <summary>
        /// Logs the current user out.
        /// </summary>
        void LogCurrentUserOut();
    }
}
