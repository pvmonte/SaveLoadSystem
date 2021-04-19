namespace UgglaGames.SaveLoadSystem
{
    public interface ILoader
    {
        T Load<T>(string fileName);
    }
}
