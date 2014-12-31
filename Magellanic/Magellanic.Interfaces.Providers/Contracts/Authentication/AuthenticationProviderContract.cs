namespace Magellanic.Interfaces.Providers.Contracts.Authentication
{
    using Magellanic.Interfaces.Domain.Security;
    using Magellanic.Interfaces.Providers.Authentication;
    using System;
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IAuthenticationProvider))]
    abstract class AuthenticationProviderContract : IAuthenticationProvider
    {
        public void LogCurrentUserOut()
        {
            
        }

        public void RegisterUser(ICredentials credentials)
        {
            Contract.Requires<ArgumentNullException>(credentials != null, "credentials cannot be a null reference");
        }

        public bool LogUserOn(ISubscriber subscriber)
        {
            Contract.Requires<ArgumentNullException>(subscriber != null, "subscriber cannot be a null reference");

            return default(bool);
        }
    }
}
