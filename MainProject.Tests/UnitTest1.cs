using MainProject.Services;

namespace MainProject.Tests;

public class HotelServiceTest
{
    [Fact]
    public void GetFullList()
    {
        var hotelService = new HotelService();
        var result = hotelService.GetList();

        Assert.Equal(10, result.Count);
        Assert.Contains(result, h => h.Name == "Seaside Paradise");
        Assert.Contains(result, h => h.Name == "Mountain Retreat");
        Assert.Contains(result, h => h.Name == "Urban Oasis");
        Assert.Contains(result, h => h.Name == "Desert Dream");
        Assert.Contains(result, h => h.Name == "Tropical Escape");
        Assert.Contains(result, h => h.Name == "Historic Haven");
        Assert.Contains(result, h => h.Name == "Safari Lodge");
        Assert.Contains(result, h => h.Name == "Ocean Breeze");
        Assert.Contains(result, h => h.Name == "Rainforest Retreat");
        Assert.Contains(result, h => h.Name == "Island Bliss");
    }

    [Fact]
    public void GetHotelById()
    {
        var hotelService = new HotelService();
        var result = hotelService.GetById("1");
        Assert.NotNull(result);
        Assert.Equal("Seaside Paradise", result.Name);
    }

    [Fact]
    public void GetNotFound()
    {
        var hotelService = new HotelService();
        var result = hotelService.GetById("99");
        Assert.Null(result);
    }
}
