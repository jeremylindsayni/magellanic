// ***********************************************************************
// Assembly         : Magellanic.Domain
// Author           : Jeremy Lindsay
// Created          : 22-Dec-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 22-Dec-2014
// ***********************************************************************
/// <summary>
/// The Security namespace.
/// </summary>
namespace Magellanic.Domain.Security
{
    using Magellanic.Interfaces.Domain.Security;

    /// <summary>
    /// The Credentials class.
    /// </summary>
    public class Credentials : ICredentials
    {
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName { get; set; }
    }
}
