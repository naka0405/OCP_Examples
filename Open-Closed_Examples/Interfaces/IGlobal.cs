namespace Open_Closed_Examples.Interfaces
{
    /// <summary>
    /// Provides access to any planet in the solar system.
    /// </summary>
    internal interface IGlobal
    {
        string GetAccess(string key);
    }
}