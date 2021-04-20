namespace UgglaGames.SaveLoadSystem
{
    /// <summary>
    /// Build file path depending on platform
    /// </summary>
    public class SaveLoadPathBuilder
    {
        string path;
        public string Path { get => path; private set => path = value; }

        public SaveLoadPathBuilder(string fileName)
        {
            Path = GetPath(fileName);
        }

        /// <summary>
        /// In Unity Editor, build path as project folder + filename.
        /// In other platforms, build path as Application.persistentDataPath + fileName
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>
        /// In Unity Editor: fileName
        /// iN Others: Application.persistentDataPath + fileName
        /// </returns>
        string GetPath(string fileName)
        {
#if UNITY_EDITOR
            //Create file in Assets folder
            return fileName;
#else
        //Create file in persistentDataPath
        return $"{Application.persistentDataPath}/{fileName}";
#endif
        }
    }
}