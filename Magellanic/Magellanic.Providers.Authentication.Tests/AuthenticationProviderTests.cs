namespace Magellanic.Providers.Authentication.Tests
{
    using Magellanic.Interfaces.Domain.Security;
    using Magellanic.Interfaces.Providers.Authentication;
    using Magellanic.Interfaces.WebSecurity;
    using NUnit.Framework;
    using Rhino.Mocks;

    [TestFixture]
    public class AuthenticationProviderTests
    {
        private IWebSecurityAdapter mockWebSecurityAdapter;

        private ICredentials mockCredentials;

        private ISubscriber mockSubscriber;

        private IAuthenticationProvider authenticationProvider;

        [SetUp]
        public void Init()
        {
            mockWebSecurityAdapter = MockRepository.GenerateMock<IWebSecurityAdapter>();

            mockCredentials = MockRepository.GenerateMock<ICredentials>();
            mockCredentials.Expect(m => m.UserName).Return("user name");
            mockCredentials.Expect(m => m.Password).Return("password");

            mockSubscriber = MockRepository.GenerateMock<ISubscriber>();
            mockSubscriber.Expect(m => m.UserName).Return("user name");
            mockSubscriber.Expect(m => m.Password).Return("password");
            mockSubscriber.Expect(m => m.IsRememberedAtNextLogOn).Return(true);
        }

        private void AuthenticationProviderFactory()
        {
            authenticationProvider = new AuthenticationProvider(mockWebSecurityAdapter);
        }


        [Test]
        public void LogCurrentUserOutTest()
        {
            // Arrange
            mockWebSecurityAdapter.Expect(x => x.LogCurrentUserOut());
            AuthenticationProviderFactory();

            // Act
            authenticationProvider.LogCurrentUserOut();

            //Assert
            mockWebSecurityAdapter.VerifyAllExpectations();
        }

        [Test]
        public void RegisterUserTest()
        {
            // Arrange
            mockWebSecurityAdapter.Expect(x => x.CreateUserAndAccount(mockCredentials.UserName, mockCredentials.Password));
            mockWebSecurityAdapter.Expect(x => x.LogUserOn(mockCredentials.UserName, mockCredentials.Password)).Return(true);
            
            AuthenticationProviderFactory();

            // Act
            authenticationProvider.RegisterUser(mockCredentials);

            // Assert
            mockWebSecurityAdapter.VerifyAllExpectations();
        }

        [Test]
        public void LogUserOnTest()
        {
            // Arrange
            mockWebSecurityAdapter.Expect(x => x.LogUserOn(mockSubscriber.UserName, mockSubscriber.Password, mockSubscriber.IsRememberedAtNextLogOn)).Return(true);

            AuthenticationProviderFactory();

            // Act
            var isLoggedOn = authenticationProvider.LogUserOn(mockSubscriber);

            // Assert
            mockWebSecurityAdapter.VerifyAllExpectations();
            Assert.True(isLoggedOn);
        }
    }
}
