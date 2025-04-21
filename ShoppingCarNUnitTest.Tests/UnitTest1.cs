namespace ShoppingCarNUnitTest.Tests;
using ShoppingCarNUnitTest;
using NUnit.Framework;

public class Tests
{
    private ShoppingCar _shoppingCar;
    
    [SetUp]
    public void Setup()
    {
        _shoppingCar = new ShoppingCar();
    }

    [Test]
    //[metodo]_[condicion]_[resultado esperado]
    public void AddItem_ItemIsEmpty_ThrowsArgumentException()
    {
        // Arrange
        string item = "";
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => _shoppingCar.AddItem(item), "El artículo no puede ser nulo o vacío.");
    }
    
    [Test]
    public void AddItem_ItemIsValid_AddsItemToCar()
    {
        // Arrange
        string item = "Manzana";
        
        // Act
        _shoppingCar.AddItem(item);
        
        // Assert
        Assert.Contains(item, _shoppingCar.Items);
    }
    
    [Test]
    public void RemoveItem_ItemIsNotInCar_ThrowsArgumentException()
    {
        // Arrange
        string item = "Naranja";
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => _shoppingCar.RemoveItem(item), "El artículo no está en el carrito.");
    }
    
    
    [Test]
    public void AddPrice_ItemIsEmpty_ThrowsArgumentException()
    {
        // Arrange
        int price = -5;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => _shoppingCar.AddPrice(price), "El precio no puede ser negativo.");
    }
    
    [Test]
    public void AddPrice_ItemIsValid_AddsPriceToCar()
    {
        // Arrange
        int price = 10;
        
        // Act
        _shoppingCar.AddPrice(price);
        
        // Assert
        Assert.Contains(price, _shoppingCar.Prices);
    }
    
    [Test]
    public void SumTotalPrice_NoItemsInCar_ReturnsZero()
    {
        // Arrange
        int expectedTotal = 0;
        
        // Act
        int total = _shoppingCar.SumTotalPrice();
        
        // Assert
        Assert.AreEqual(expectedTotal, total, "El total debería ser 0.");
    }
    
}