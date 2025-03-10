using EShop.Application.Services;
namespace EShop.Application.Tests.Services;

public class CreditCardServiceTests
{
    [Fact]
    public void ValidateCard_CheckCardTooShort_ReturnTrue()
    {
        //Arange
        var creditCardService = new CreditCardService();
        string cardNumber = "1212";

        //Act
        var result = creditCardService.ValidateCard(cardNumber);

        //Assert 
        Assert.True(result);
    }
    [Fact]
    public void ValidateCard_CheckCardTooShort_ReturnFalse()
    {
        //Arange
        var creditCardService = new CreditCardService();
        string cardNumber = "1234567899";

        //Act
        var result = creditCardService.ValidateCard(cardNumber);

        //Assert 
        Assert.False(result);
    }
    [Fact]
    public void ValidateCard_CheckCardTooLong_ReturnFalse()
    {
        //Arange
        var creditCardService = new CreditCardService();
        string cardNumber = "1234567899";

        //Act
        var result = creditCardService.ValidateCard(cardNumber);

        //Assert 
        Assert.False(result);
    }
    [Fact]
    public void ValidateCard_CheckCardTooLong_ReturnTrue()
    {
        //Arange
        var creditCardService = new CreditCardService();
        string cardNumber = "12345678901234";

        //Act
        var result = creditCardService.ValidateCard(cardNumber);

        //Assert 
        Assert.True(result);
    }
    [Fact]
    public void ValidateCard_CheckCardSpaces_ReturnTrue()
    {
        //Arange
        var creditCardService = new CreditCardService();
        string cardNumber = "1 2 3 4 5 6 7 8 9 0 ";

        //Act
        var result = creditCardService.ValidateCard(cardNumber);

        //Assert 
        Assert.Equal("1234567890", result);
    }
    public void ValidateCard_CheckCardSpaces_ReturnFalse()
    {
        //Arange
        var creditCardService = new CreditCardService();
        string cardNumber = "1-2-3-4-5-6-7-8-9-0";

        //Act
        var result = creditCardService.ValidateCard(cardNumber);

        //Assert 
        Assert.True(result);
    }
}