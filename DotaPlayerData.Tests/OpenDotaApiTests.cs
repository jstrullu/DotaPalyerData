using DotaPlayerData.API;
using Moq;
using RestSharp;

namespace DotaPlayerData.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        var restClientMock = new Mock<RestClient>();
        var responseMock = new Mock<RestResponse>();
        responseMock.Setup(response => response.IsSuccessful).Returns(true);
        responseMock.Setup(response => response.Content).Returns("Mocked heroes data");

        restClientMock
            .Setup(restClient => restClient.ExecuteAsync(It.IsAny<RestRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(responseMock.Object);

        OpenDotaApiClient openDotaApiClient = new (restClientMock.Object);

        // Act
        string result = await openDotaApiClient.GetAllDotaHeroes();

        // Assert
        Assert.AreEqual("Mocked heroes data", result);
        // Ajoutez d'autres assertions selon vos attentes.
    }
}