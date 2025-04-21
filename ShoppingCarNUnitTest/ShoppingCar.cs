namespace ShoppingCarNUnitTest
{
    public class ShoppingCar
    {
        public List<string> Items { get; private set; }
        public List<int> Prices { get; private set; }

        public ShoppingCar()
        {
            Items = new List<string>();
            Prices = new List<int>();
        }

        public void AddItem(string item)
        {
            if (string.IsNullOrEmpty(item))
            {
                throw new ArgumentException("El artículo no puede ser nulo o vacío.");
            }
            Items.Add(item);
        }

        public void RemoveItem(string item)
        {
            // excepción a la fuerza para probar el test unitario RemoveItem_ItemIsNotInCar_ThrowsArgumentException
            Items.Remove(item);
        }

        public void ClearCar()
        {
            Items.Clear();
        }
        
        public void AddPrice(int price)
        {
            if (price < 0)
            {
                throw new ArgumentException("El precio no puede ser negativo.");
            }
            Prices.Add(price);
        }
        
        public void RemovePrice(int price)
        {
            if (!Prices.Contains(price))
            {
                throw new ArgumentException("El precio no está en la lista.");
            }
            Prices.Remove(price);
        }
        
        public int SumTotalPrice()
        {
            int total = 0;
            foreach (var price in Prices)
            {
                total += price;
            }

            return total;
        }
    }
}