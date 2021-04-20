using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

namespace UgglaGames.SaveLoadSystem
{
    /// <summary>
    /// Loads data from .bin file with name fileName
    /// </summary>
    public class LoaderFromBinary : ILoader
    {
        /// <summary>
        /// Loads data from .bin file with name fileName
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns>Returns loaded data as an object of class T</returns>
        public T Load<T>(string fileName)
        {
            string path = $"{new SaveLoadPathBuilder(fileName).Path}.bin";

            if (!File.Exists(path))
                return default(T);

            var binaryFormatter = new BinaryFormatter();
            var fileStream = new FileStream(path, FileMode.Open);

            T data = (T)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return data;
        }
    }
}
