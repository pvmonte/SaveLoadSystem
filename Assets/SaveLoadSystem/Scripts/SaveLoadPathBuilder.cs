namespace UgglaGames.SaveLoadSystem
{
    public class SaveLoadPathBuilder
    {
        string path;
        public string Path { get => path; private set => path = value; }

        public SaveLoadPathBuilder(string fileName)
        {
            Path = GetPath(fileName);
        }

        public string GetPath(string fileName)
        {
#if UNITY_EDITOR
            //Create file in Assets folder
            return fileName;
#else
        //Create file in persistentDataPath
        return $"{Application.persistentDataPath}/{fileName}.json";
#endif
        }
    }
}