using Moq;
using VirtualAssitant.Core.Client;
using VirtualAssitant.Core.Entities;
using VirtualAssitant.Core.PlaceManager;

namespace VirtualAssistant.Test;

public class UnitTest1
{
    [Fact]
    public async Task GetPlacesByCityAndCategoryAsync_ReturnsListOfPlaces()
    {
        // Arrange
        var city = "New York";
        var category = "Cargo";
        var cityInformation = new City
        {
            Name = "New York",
            Country = "United States of America"
        };
        var places = new List<Place>
        {
            new Place
            {
                Name = "Pronto Cargo",
                AddressLine1 = "69 ST",
                AddressLine2 = "DPT 40",
                Street = "Green street"
            },
            new Place
            {
                Name = "Rapido Cargo",
                AddressLine1 = "70 ST",
                AddressLine2 = "DPT 41",
                Street = "Blue street"
            }
        };

        var geopifyClientMock = new Mock<IGeopifyClient>();
        geopifyClientMock.Setup(c => c.GetCityAsync(city)).ReturnsAsync(new List<City> { cityInformation });
        geopifyClientMock.Setup(c => c.GetPlacesAsync(cityInformation.PlaceId, category)).ReturnsAsync(places);

        var placeService = new PlaceService(geopifyClientMock.Object);

        // Act
        var result = await placeService.GetPlacesByCityAndCategoryAsync(city, category);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(places, result.Result);
    }
}
