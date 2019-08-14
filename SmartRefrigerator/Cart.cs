using System.Collections.Generic;

namespace SmartRefrigerator
{
    public class Cart
    {
        public Dictionary<Vegetable, int> cartValue = new Dictionary<Vegetable, int>();
        public Cart()
        {
            cartValue.Clear();
        }

        public void AddVegetableToCart(Vegetable vegetable, int quantity)
        {
            cartValue.Add(vegetable, quantity);
        }

        public Dictionary<Vegetable, int> ShowCart()
        {
            return cartValue;
        }
    }
}
