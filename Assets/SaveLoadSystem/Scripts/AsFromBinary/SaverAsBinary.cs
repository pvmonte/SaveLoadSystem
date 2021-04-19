using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

namespace UgglaGames.SaveLoadSystem
{
    public class SaverAsBinary : ISaver
    {
        public void Save<T>(T data, string fileName)
        {
            string path = new SaveLoadPathBuilder(fileName).Path;

            var binaryFormatter = new BinaryFormatter();
            var fileStream = new FileStream(path, FileMode.Create);

            binaryFormatter.Serialize(fileStream, data);
            fileStream.Close();
        }
    }
}
