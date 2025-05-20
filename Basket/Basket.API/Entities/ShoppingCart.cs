namespace Basket.API.Entities;

public class ShoppingCart
{
    public string Username { get; set; }
    public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

    public ShoppingCar()
    {
    }

    public ShoppingCart(string username)
    {
        Username = username;
    }
    
    pubic decimal TotalPrice
    {
        get
        {
            decimal totalPrice = 0;
            foreach (var item in Items )
            {
                totalPrice += item.Price * item.Quantity;
            }

            return totalPrice;
        }
    }
}