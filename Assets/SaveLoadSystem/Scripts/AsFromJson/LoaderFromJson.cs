using System.IO;
using UnityEngine;

namespace UgglaGames.SaveLoadSystem
{
    public class LoaderFromJson : ILoader
    {
        public T Load<T>(string fileName)
        {
            string path = new SaveLoadPathBuilder(fileName).Path;

            if (!File.Exists(path))
                return default(T);

            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<T>(json);
        }
    }
}
