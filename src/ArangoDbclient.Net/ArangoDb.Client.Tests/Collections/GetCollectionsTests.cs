using System.Net.Http;
using System.Threading.Tasks;
using ArangoDb.Client.Collections;
using Xunit;

namespace ArangoDb.Client.Tests.Collections
{
    public class GetCollectionsTests : IntegrationTestsBase
    {
        private static volatile string _authenticationToken;

        [Fact]
        public async Task WhenQuerying_InvalidDatabase_ShouldThrowException()
        {
            // Arrange
            _authenticationToken = (await Authenticate("root", "")).Jwt;
            var getCollections = new GetAllCollectionsRequest
                {AuthenticationToken = _authenticationToken, CurrentDatabase = "1232"};
            
            // Act
            var exception = await Assert.ThrowsAsync<HttpRequestException>(async () =>
                await ClientHandler.GetAsync<GetAllCollectionsRequest, GetAllCollectionsResponse>(getCollections));
            
            // Assert
            Assert.NotNull(exception);
        }
        
        [Theory]
        [InlineData("Orleans")]
        public async Task WhenQuerying_CustomDatabase_ShouldReturnCollections(string database)
        {
            // Arrange
            _authenticationToken = (await Authenticate("root", "")).Jwt;
            var getCollections = new GetAllCollectionsRequest { AuthenticationToken = _authenticationToken, CurrentDatabase = database};
            
            // Act
            var collectionsResponse =
                await ClientHandler.GetAsync<GetAllCollectionsRequest, GetAllCollectionsResponse>(getCollections);
            
            // Assert
            Assert.NotEmpty(collectionsResponse.Result);
        }
    }
}