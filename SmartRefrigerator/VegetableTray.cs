using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRefrigerator
{
    public class VegetableTray
    {
        private Dictionary<Vegetable, int> _vegetableQuantity = new Dictionary<Vegetable, int>();

        public void Add(Vegetable vegetable, int quantity)
        {
            if (_vegetableQuantity.ContainsKey(vegetable))
            {
                var updatedQuantity = _vegetableQuantity[vegetable] += quantity;
                _vegetableQuantity[vegetable] = updatedQuantity;
            }
            else
            {
                _vegetableQuantity.Add(vegetable, quantity);
            }
        }

        public void TakeOut(Vegetable vegetable, int quantity)
        {
            if (_vegetableQuantity.ContainsKey(vegetable))
            {
                var updatedQuantity = _vegetableQuantity[vegetable] -= quantity;

                if (updatedQuantity <= 0)
                {
                    _vegetableQuantity.Remove(vegetable);
                }
                else
                {
                    _vegetableQuantity[vegetable] = updatedQuantity;
                }
            }
            else
            {
                throw new VegetableNotFoundException();
            }
        }

        public List<KeyValuePair<Vegetable, int>> GetVegetableQuantity()
        {
            var vegetableQuantity = new List<KeyValuePair<Vegetable, int>>();

            foreach (var item in _vegetableQuantity)
            {
                vegetableQuantity.Add(new KeyValuePair<Vegetable, int>(item.Key, item.Value));
            }

            return vegetableQuantity;
        }
    }
}
