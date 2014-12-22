// ***********************************************************************
// Assembly         : Magellanic.Providers.AuthenticationProvider
// Author           : Jeremy Lindsay
// Created          : 22-Dec-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 22-Dec-2014
// ***********************************************************************
/// <summary>
/// The Authentication namespace.
/// </summary>
namespace Magellanic.Providers.Authentication
{
    using Magellanic.Interfaces.Domain.Security;
    using Magellanic.Interfaces.Providers.Authentication;
    using Magellanic.Interfaces.WebSecurity;

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
        public bool LogUserOn(ISubscriber subscriber)
        {
            return this.WebSecurityAdapter.LogUserOn(subscriber.UserName, subscriber.Password, subscriber.IsRememberedAtNextLogOn);
        }
    }
}
