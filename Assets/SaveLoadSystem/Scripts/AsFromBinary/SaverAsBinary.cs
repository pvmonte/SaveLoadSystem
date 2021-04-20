using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

namespace UgglaGames.SaveLoadSystem
{
    /// <summary>
    /// Saves data as .bin file with name fileName
    /// </summary>
    public class SaverAsBinary : ISaver
    {
        /// <summary>
        /// Transforms object of a class T into .bin and stores it with name = fileName
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="fileName"></param>
        public void Save<T>(T data, string fileName)
        {
            string path = $"{new SaveLoadPathBuilder(fileName).Path}.bin";

            var binaryFormatter = new BinaryFormatter();
            var fileStream = new FileStream(path, FileMode.Create);

            binaryFormatter.Serialize(fileStream, data);
            fileStream.Close();
        }
    }
}
