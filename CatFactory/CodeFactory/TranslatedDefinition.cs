namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents the method that will handle an event to translate object definition to code lines
    /// </summary>
    /// <param name="source">The source of the event</param>
    /// <param name="args">An object that contains translate information</param>
    public delegate void TranslatedDefinition(object source, TranslatedDefinitionEventArgs args);
}
