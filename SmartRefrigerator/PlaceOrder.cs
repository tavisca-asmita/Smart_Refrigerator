using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRefrigerator
{
    public class PlaceOrder
    {
        private VegetableTracker _vegetableTracker;
        private ConfigurationManager _configurationManager;

        public PlaceOrder(VegetableTray vegetableTray, ConfigurationManager configurationManager)
        {
            this._configurationManager = configurationManager;           
            _vegetableTracker = new VegetableTracker(vegetableTray, configurationManager);
        }              

        public Dictionary<Vegetable, int> PlaceOrderOfInsufficientVegetables()
        {
            Cart cart = new Cart();

            var insufficientVegetableQuantity = new List<KeyValuePair<Vegetable, int>>(_vegetableTracker.GetInsufficientVegetableQuantity()) ;
            
            foreach(var item in insufficientVegetableQuantity)
            {
                cart.AddVegetableToCart(item.Key, item.Value);
            }

            return cart.ShowCart();
        }
         
        
    }
}
