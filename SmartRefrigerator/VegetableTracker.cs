using System.Collections.Generic;

namespace SmartRefrigerator
{
    public class VegetableTracker
    {
        private ConfigurationManager configurationManager;
        private VegetableTray vegetableTray;

        public VegetableTracker(VegetableTray vegetableTray, ConfigurationManager configurationManager)
        {
            this.configurationManager = configurationManager;
            this.vegetableTray = vegetableTray;
        }

        public List<KeyValuePair<Vegetable, int>> GetInsufficientVegetableQuantity()
        {
            var insufficientVegetableQuantityList = new List<KeyValuePair<Vegetable, int>>();
            var insufficientVegetableQuantity = new Dictionary<Vegetable, int>();
            var vegetableQuantity = new List<KeyValuePair<Vegetable, int>>();

            vegetableQuantity = vegetableTray.GetVegetableQuantity();
                        
            foreach (var item in vegetableQuantity)
            {                
                if ((configurationManager.GetMinimumQuantity(item.Key)) > item.Value)
                {                    
                    insufficientVegetableQuantity.Add(item.Key, (configurationManager.GetMinimumQuantity(item.Key)) - item.Value);
                }
            }

            foreach(var item in insufficientVegetableQuantity)
            {
                insufficientVegetableQuantityList.Add(item);
            }
            return insufficientVegetableQuantityList;

        }
    }
}
