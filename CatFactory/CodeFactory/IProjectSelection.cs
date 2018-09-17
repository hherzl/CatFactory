namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TProjectSettings"></typeparam>
    public interface IProjectSelection<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
    }
}
