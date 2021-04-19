using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace UgglaGames.SaveLoadSystem
{
    public class SaverAsJson : ISaver
    {
        public void Save<T>(T data, string fileName)
        {
            string path = new SaveLoadPathBuilder(fileName).Path;

            if (!File.Exists(path))
                return;

            string json = JsonUtility.ToJson(data);
            File.WriteAllText(path, json);
        }
    }
}
