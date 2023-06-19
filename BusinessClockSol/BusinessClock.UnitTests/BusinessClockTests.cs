using BusinessClockAPi.Models;
using BusinessClockAPi.Services;
namespace BusinessClock.UnitTests;



public class BusinessClockTests
{



    [Fact]
    public void ClosedOnSaturday()
    {
        //When 
        BusinessClockService clock = new BusinessClockService();
        //Given
        GetStatusResponse response = clock.GetCurrentStatus();
        //Then
        Assert.False(response.Open);

    }



    [Fact]
    public void ClosedOnSunday()
    {
        //When 
        BusinessClockService clock = new BusinessClockService();
        //Given
        GetStatusResponse response = clock.GetCurrentStatus();
        //Then
        Assert.False(response.Open);
    }
}