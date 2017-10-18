namespace CatFactory.CodeFactory
{
    public interface ILine
    {
        int Indent { get; }

        string Content { get; }

        bool IsNullOrEmpty { get; }
    }
}
