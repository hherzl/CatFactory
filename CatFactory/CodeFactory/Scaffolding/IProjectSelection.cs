namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TProjectSettings"></typeparam>
    public interface IProjectSelection<TProjectSettings> where TProjectSettings : class, IProjectSettings, new()
    {
    }
}
