using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

namespace UgglaGames.SaveLoadSystem
{
    public class LoaderFromBinary : ILoader
    {
        public T Load<T>(string fileName)
        {
            string path = new SaveLoadPathBuilder(fileName).Path;

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
