using System.IO;
using UnityEngine;

namespace UgglaGames.SaveLoadSystem
{
    /// <summary>
    /// Loads data from .json file with name fileName
    /// </summary>
    public class LoaderFromJson : ILoader
    {
        /// <summary>
        /// Loads data from .json file with name fileName
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns>Returns loaded data as an object of class T</returns>
        public T Load<T>(string fileName)
        {
            string path = $"{new SaveLoadPathBuilder(fileName).Path}.json";

            if (!File.Exists(path))
                return default(T);

            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<T>(json);
        }
    }
}
