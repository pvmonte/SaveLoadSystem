namespace UgglaGames.SaveLoadSystem
{
    public interface ISaver
    {
        void Save<T>(T data, string fileName);
    }
}
