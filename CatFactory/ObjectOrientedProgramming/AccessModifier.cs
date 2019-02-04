namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Specifies the accessibility of a type or member when you declare it
    /// </summary>
    /// <remarks>Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers</remarks>
    public enum AccessModifier
    {
        /// <summary>
        /// The type or member can be accessed only by code in the same class or struct.
        /// </summary>
        Private = 0,

        /// <summary>
        /// The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class.
        /// </summary>
        PrivateProtected = 5,

        /// <summary>
        /// The type or member can be accessed by any code in the same assembly, but not from another assembly.
        /// </summary>
        Internal = 10,

        /// <summary>
        /// The type or member can be accessed by any other code in the same assembly or another assembly that references it.
        /// </summary>
        Public = 20,

        /// <summary>
        /// The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
        /// </summary>
        Protected = 30,

        /// <summary>
        /// The type or member can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly.
        /// </summary>
        ProtectedInternal = 35
    }
}
