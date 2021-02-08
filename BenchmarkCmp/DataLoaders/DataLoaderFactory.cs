using BenchmarkCmp.DataLoaders.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BenchmarkCmp.DataLoaders
{
    public static class DataLoaderFactory
    {
        private static readonly Dictionary<string, Func<IDataLoader>> _loaders = new()
        {
            { ".json", () => new JsonDataLoader() }
        };
        public static string[] SupportedExtensions => _loaders.Keys.ToArray();

        public static IDataLoader GetLoader(string filePath)
        {
            var extension = Path.GetExtension(filePath);

            if (_loaders.TryGetValue(extension, out var loaderFactory))
            {
                return loaderFactory();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(extension));
            }
        }
    }
}
