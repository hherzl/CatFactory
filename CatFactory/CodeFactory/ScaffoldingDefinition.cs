namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents the method that will handle an event to scaffolding an object definition
    /// </summary>
    /// <param name="source">The source of the event</param>
    /// <param name="args">An object that contains scaffolding information</param>
    public delegate void ScaffoldingDefinition(object source, ScaffoldingDefinitionEventArgs args);
}
