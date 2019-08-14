namespace SmartRefrigerator
{
    public class Refrigerator
    {
        private VegetableTray _vegetableTray = new VegetableTray();

        private ConfigurationManager _configurationManager;

        private StorageFactory _storageFactory = new StorageFactory();

        public void AddVegetable(Vegetable vegetable, int quantity)
        {
            _vegetableTray.Add(vegetable, quantity);
            _configurationManager = new ConfigurationManager(_storageFactory.GetStorage("database"));
        }

        public void TakeOutVegetable(Vegetable vegetable, int quantity)
        {
            _vegetableTray.TakeOut(vegetable, quantity);

            var vegetableQuantity = _vegetableTray.GetVegetableQuantity();
        }


    }
}
