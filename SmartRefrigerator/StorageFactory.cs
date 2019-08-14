using System;

namespace SmartRefrigerator
{
    public class StorageFactory
    {
        public IStorage GetStorage(string storageType)
        {
            switch(storageType.ToLowerInvariant())
            {
                case "inmemory":
                    return new InMemoryStorage();

                case "filebased":
                    return new FileSystemBasedStorage();

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
