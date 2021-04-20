using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace UgglaGames.SaveLoadSystem
{
    /// <summary>
    /// Saves data as .json file with name fileName
    /// </summary>
    public class SaverAsJson : ISaver
    {
        /// <summary>
        /// Transforms object of a class T into json and stores it with name = fileName
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="fileName"></param>
        public void Save<T>(T data, string fileName)
        {
            string path = $"{new SaveLoadPathBuilder(fileName).Path}.json";

            if (!File.Exists(path))
                return;

            string json = JsonUtility.ToJson(data);
            File.WriteAllText(path, json);
        }
    }
}
