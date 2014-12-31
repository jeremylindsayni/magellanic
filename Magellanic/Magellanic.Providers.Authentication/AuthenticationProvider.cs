// ***********************************************************************
// Assembly         : Magellanic.Providers.Authentication
// Author           : Jeremy Lindsay
// Created          : 22-Dec-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 29-Dec-2014
// ***********************************************************************
/// <summary>
/// The Authentication namespace.
/// </summary>
namespace Magellanic.Providers.Authentication
{
    using Magellanic.Interfaces.Domain.Security;
    using Magellanic.Interfaces.Providers.Authentication;
    using Magellanic.Interfaces.WebSecurity;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The Authentication provider class
    /// </summary>
    public class AuthenticationProvider : IAuthenticationProvider
    {
        /// <summary>
        /// Gets or sets the web security adapter.
        /// </summary>
        /// <value>The web security adapter.</value>
        public IWebSecurityAdapter WebSecurityAdapter { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationProvider"/> class.
        /// </summary>
        /// <param name="webSecurityAdapter">The web security adapter.</param>
        public AuthenticationProvider(IWebSecurityAdapter webSecurityAdapter)
        {
            Contract.Requires<ArgumentNullException>(webSecurityAdapter != null, "webSecurityAdapter must not be null");
            this.WebSecurityAdapter = webSecurityAdapter;
        }

        /// <summary>
        /// Logs the current user out.
        /// </summary>
        public void LogCurrentUserOut()
        {
            this.WebSecurityAdapter.LogCurrentUserOut();
        }

        /// <summary>
        /// Registers the user.
        /// </summary>
        /// <param name="credentials">The credentials of the user attempting to register.</param>
        /// <exception cref="ArgumentNullException">Thrown if credentials is a null reference.</exception>
        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", Justification = "Using code contracts to achieve this.")]
        public void RegisterUser(ICredentials credentials)
        {
            this.WebSecurityAdapter.CreateUserAndAccount(credentials.UserName, credentials.Password);
            this.WebSecurityAdapter.LogUserOn(credentials.UserName, credentials.Password);
        }

        /// <summary>
        /// Logs the user on.
        /// </summary>
        /// <param name="subscriber">The subscriber.</param>
        /// <returns><c>true</c> if credentials are successfully authenticated, <c>false</c> otherwise.</returns>
        /// <exception cref="ArgumentNullException">Thrown if subscriber is a null reference.</exception>
        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", Justification = "Using code contracts to achieve this.")]
        public bool LogUserOn(ISubscriber subscriber)
        {
            return this.WebSecurityAdapter.LogUserOn(subscriber.UserName, subscriber.Password, subscriber.IsRememberedAtNextLogOn);
        }
    }
}