// ***********************************************************************
// Assembly         : Magellanic.Interfaces.Providers
// Author           : Jeremy Lindsay
// Created          : 21-Dec-2014
//
// Last Modified By : Jeremy Lindsay
// Last Modified On : 21-Dec-2014
// ***********************************************************************
/// <summary>
/// The Authentication namespace.
/// </summary>
namespace Magellanic.Interfaces.Providers.Authentication
{
    using Magellanic.Interfaces.Domain.Security;
    using Magellanic.Interfaces.Providers.Contracts.Authentication;
    using System.Diagnostics.Contracts;

    /// <summary>
    /// The IAuthenticationProvider interface.
    /// </summary>
    [ContractClass(typeof(AuthenticationProviderContract))]
    public interface IAuthenticationProvider
    {
        /// <summary>
        /// Logs the current user out.
        /// </summary>
        void LogCurrentUserOut();

        /// <summary>
        /// Registers the user.
        /// </summary>
        /// <param name="credentials">The credentials of the user attempting to register.</param>
        void RegisterUser(ICredentials credentials);

        /// <summary>
        /// Logs the user on.
        /// </summary>
        /// <param name="subscriber">The subscriber.</param>
        /// <returns><c>true</c> if credentials are successfully authenticated, <c>false</c> otherwise.</returns>
        bool LogUserOn(ISubscriber subscriber);
    }
}
