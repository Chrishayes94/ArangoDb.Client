using System.Threading.Tasks;
using ArangoDb.Client.Authentication;
using Xunit;

namespace ArangoDb.Client.Tests.Authentication
{
    public class GenerateAuthenticationTests : IntegrationTestsBase
    {
        [Fact]
        public async Task When_ValidUsernameAndPassword_ShouldCreateJWT()
        {
            // Arrange
            const string username = "root";
            const string password = "";
            
            // Act
            var authenticationResponse = await Authenticate(username, password);
            
            // Assert
            Assert.True(!string.IsNullOrEmpty(authenticationResponse.Jwt));
        }
    }
}