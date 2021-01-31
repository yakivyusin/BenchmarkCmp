using BenchmarkCmp.DataLoaders.Concrete;
using System;
using System.IO;

namespace BenchmarkCmp.DataLoaders
{
    public static class DataLoaderFactory
    {
        public static IDataLoader GetLoader(string filePath)
        {
            var extension = Path.GetExtension(filePath);

            switch (extension)
            {
                case ".json":
                    return new JsonDataLoader();
                default:
                    throw new ArgumentOutOfRangeException(nameof(filePath));
            }
        }
    }
}
