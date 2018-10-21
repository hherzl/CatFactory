namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// Represents the method that will handle an event to scaffolded an object definition
    /// </summary>
    /// <param name="source">The source of the event</param>
    /// <param name="args">An object that contains scaffolding information</param>
    public delegate void ScaffoldedDefinition(object source, ScaffoldedDefinitionEventArgs args);
}
